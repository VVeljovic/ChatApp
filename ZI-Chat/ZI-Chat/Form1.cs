
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace ZI_Chat
{
    public partial class Form1 : Form
    {
       
        private static Enigma enigma;
        private static int pid = Process.GetCurrentProcess().Id;
        private static CFB cfb;
        public Form1()
        {
            InitializeComponent();
            enigma = new Enigma();
            cfb = new CFB();
            enigma.generateRotors(3);
            enigma.generateRotors(323);
            enigma.connect(2);
            enigma.createReflector();
            enigma.generatePlugboard(30);
            Thread t1 = new Thread(() =>
            {
                SetupNotification();
            });
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
           
        }
      
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SetupNotification()
        {

            var connString = "Server=localhost ; port=5432 ; user id=postgres; password=Veljko22!!!; database=ZI-Chat ; ";
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "LISTEN message_inserted";

                    cmd.ExecuteNonQuery();
                }


                conn.Notification += (o, e) =>
                {
                   
                    var payload = Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<string, string>>(e.Payload);
                    int direction = 0;

                    if (payload.TryGetValue("encrypted_message", out var encryptedMessage) &&
                        payload.TryGetValue("owner", out var owner) &&payload.TryGetValue("offset",out var offset))
                    {
                       
                        if (!string.Equals(pid.ToString(), owner, StringComparison.OrdinalIgnoreCase))
                        {
                            direction = 1;
                            string text = "";
                            if (buttonEnigma.Checked)
                               text= enigma.EncryptMessage(encryptedMessage, 1);
                            else if (buttonXXTEA.Checked)
                                text = cfb.decrypt(encryptedMessage);
                            if (switchOption.Checked)
                                AddMessage(encryptedMessage,direction);
                            AddMessage(text,direction);
                            string br = offset.ToString();

                            enigma.connect(int.Parse(br));
                        }
                        else
                        {
                            direction = -1;
                            AddMessage(txtMessage.Text,direction);
                            if (switchOption.Checked)
                                AddMessage(encryptedMessage, direction);
                            
                           
                            
                            string br = offset.ToString();

                            enigma.connect(int.Parse(br));

                        }
                    }
                };

                while (true)
                    conn.Wait();
            }
        }
        void AddMessage(string message, int direction)
        {
            if (pnlContainer.InvokeRequired)
            {
                pnlContainer.Invoke(new Action(() =>
                {
                    Control bubble;

                    if (direction == -1)
                    {
                        
                        bubble = new ChatItems.Outgoing();
                    }
                    else
                    {
                        
                        bubble = new ChatItems.Incomming();
                    }

                    pnlContainer.Controls.Add(bubble);
                    bubble.BringToFront();
                    bubble.Dock = DockStyle.Top;

                   
                    dynamic dynamicBubble = bubble;
                    dynamicBubble.Message = message;

                    txtMessage.Text = string.Empty;
                }));
            }
        }





        private void btnSend_Click(object sender, EventArgs e)
        {
            Random br = new Random();
            int br2 = br.Next(0, 26 * 25 * 24);
            Thread t2 = new Thread(() =>
            {
                var connString = "Server=localhost ; port=5432 ; user id=postgres; password=Veljko22!!!; database=ZI-Chat ; ";
               
                using (var conn2 = new NpgsqlConnection(connString))
                {
                    conn2.Open();
                    string insertQuery = "INSERT INTO public.messages (encrypted_message, owner,\"offset\") VALUES (@encrypted_message, @owner,@offset) ";
                    using (var cmd = new NpgsqlCommand(insertQuery, conn2))
                    {
                        try
                        {
                            string crypted = "";
                            if (buttonEnigma.Checked)
                               crypted= enigma.EncryptMessage(txtMessage.Text, 0);
                            else if (buttonXXTEA.Checked)
                            {
                               crypted= cfb.encrypt(txtMessage.Text);
                            }
                            cmd.Parameters.AddWithValue("@encrypted_message", crypted);
                            cmd.Parameters.AddWithValue("@owner", pid.ToString());
                            cmd.Parameters.AddWithValue("@offset", br2);

                            cmd.ExecuteNonQuery();


                            
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error inserting into the database: " + ex.Message);
                        }
                    }
                   

                }

            });
            t2.SetApartmentState(ApartmentState.STA);
            t2.Start();


          
        }


    }
}