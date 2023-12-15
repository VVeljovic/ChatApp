using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZI_Chat
{
    public class Enigma
    {
        private string[] rotors = new string[3];
        private string reflector;
        private Dictionary<char, char> plugboards;
        
        private Dictionary<char, char> wires12;
        private Dictionary<char, char> wires23;
        private Dictionary<char, char> reflectorPairs;
        
        public Enigma()
        {
            wires12 = new Dictionary<char, char>();
            wires23 = new Dictionary<char, char>();
            reflectorPairs = new Dictionary<char, char>();
            plugboards = new Dictionary<char, char>();
            
        
        }
        private string GenerateShuffledAlphabet(int seed)
        {
            char[] alphabet = new char[26];

            for (int i = 0; i < 26; i++)
            {
                alphabet[i] = (char)('a' + i);
            }
            Random random = new Random(seed);

            for (int i = alphabet.Length - 1; i > 0; i--)
            {
                int j = random.Next(0, i + 1);
                
                char temp = alphabet[i];
                alphabet[i] = alphabet[j];
                alphabet[j] = temp;
            }

            return new string(alphabet);
        }
        public void generatePlugboard(int seed)
        {
           
            Random random = new Random(seed);

            int numberOfPairs = random.Next(1, 27);
            for (int i = 0; i < numberOfPairs; i++)
            {
                int number1 = random.Next(0, 26);
                char letter1 = (char)('a' + number1);
                int number2 = random.Next(0, 26);
                char letter2 = (char)('a' + number2);

                if (!plugboards.ContainsKey(letter1) && !plugboards.ContainsKey(letter2) &&
                    !plugboards.ContainsValue(letter1) && !plugboards.ContainsValue(letter2))
                {
                    plugboards.Add(letter1, letter2);
                }
            }
           
        }
        public void generateRotors(int e)
        {
            for (int k = 0; k < e; k++)
            {
                
                if (e == 3)
                    rotors[k] = GenerateShuffledAlphabet(k);
                else
                    reflector = GenerateShuffledAlphabet(e);
            }
           
        }
        public void createReflector()
        {
            int middle = reflector.Length / 2;
            string keys = reflector.Substring(0, middle);
            string values = reflector.Substring(middle);
            char[] keysArray = keys.ToCharArray();
            char[] valuesArray = values.ToCharArray();
            for (int i = 0; i < middle; i++)
            {
                reflectorPairs.Add(keysArray[i], valuesArray[i]);
            }
           
          

        }
        public void connect(int numbers)
        {

            
            int offset = numbers;
                     wires12.Clear();
                     wires23.Clear();
                for (int i = 0; i < 26; i++)
                {

                    wires12.Add(rotors[0][i], rotors[1][(i + offset) % 26]);
                    wires23.Add(rotors[1][i], rotors[2][(i + offset) % 26]);

                }
          

        }
        private char Encrypt(char letter)
        {

            char pair = plugboards.ContainsKey(letter) ? plugboards[letter] : letter;
            if (pair == letter)
                pair = plugboards.ContainsValue(pair) ? plugboards.FirstOrDefault(x => x.Value == letter).Key : letter;

           
            pair = wires12[pair];
          
            pair = wires23[pair];
           
            char reflected = reflectorPairs.ContainsKey(pair) ? reflectorPairs[pair] : pair;
            if (reflected == pair)
                reflected = reflectorPairs.ContainsValue(reflected) ? reflectorPairs.FirstOrDefault(x => x.Value == reflected).Key : reflected;
           
            reflected = wires23[reflected];
           
            reflected = wires12[reflected];
           
            char retVal = plugboards.ContainsKey(reflected) ? plugboards[reflected] : reflected;
            if (reflected == retVal)
                retVal = plugboards.ContainsValue(reflected) ? plugboards.FirstOrDefault(x => x.Value == reflected).Key : reflected;
            return retVal;
        }
        private  char Decrypt(char letter)
        {
            char reflected = plugboards.ContainsKey(letter) ? plugboards[letter] : letter;
            if (reflected == letter)
                reflected = plugboards.ContainsValue(letter) ? plugboards.FirstOrDefault(x => x.Value == letter).Key : letter;
            reflected = wires12.FirstOrDefault(x => x.Value == reflected).Key;
            reflected = wires23.FirstOrDefault(x => x.Value == reflected).Key;
            char let = reflectorPairs.ContainsKey(reflected) ? reflectorPairs[reflected] : reflected;
            if (let == reflected)
                let = reflectorPairs.ContainsValue(reflected) ? reflectorPairs.FirstOrDefault(x => x.Value == reflected).Key : reflected;
            let = wires23.FirstOrDefault(x => x.Value == let).Key;
            let = wires12.FirstOrDefault(x => x.Value == let).Key;
            char pair = plugboards.ContainsKey(let) ? plugboards[let] : let;
            if (pair == let)
                pair = plugboards.ContainsValue(pair) ? plugboards.FirstOrDefault(x => x.Value == let).Key : let;
            return pair;
        }
        public string  EncryptMessage(string message,int direction,int off )
        {
            if (off == 0)
            {
                if (direction == 1)
                {
                    byte[] bytes = Convert.FromBase64String(message);
                    string decodedString = Encoding.UTF8.GetString(bytes);
                    return decodedString;
                }
                else
                    return message;
            }
            int vs = 0;
            char[] characters = message.ToCharArray();
            char[] return_message = new char[message.Length];
            message = message.ToLower();
            for (int i = 0; i<message.Length;i++)
            {
                if (char.IsLetter(message[i]))
                {
                    if(char.IsUpper(characters[i]))
                    {
                        vs = 1;
                        
                    }
                    if (direction == 0)
                        return_message[i] = Encrypt(message[i]);
                    else
                        return_message[i] = Decrypt(message[i]);
                    if(vs == 1)
                    {
                        return_message[i] = char.ToUpper(return_message[i]);
                    }
                }
               else
                {
                    
                    return_message[i] = message[i];
                }
                vs = 0; 
            }
            string retVal = new string(return_message);
            return retVal;

        }
        
    }
}
