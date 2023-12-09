using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZI_Chat
{
    public class XXTEA
    {
        private const uint DELTA = 0x9e3779b9;
        private static uint MX(uint z, uint y, uint sum, uint e, uint p, uint[] k)
        {

            return (((z >> 5 ^ y << 2) + (y >> 3 ^ z << 4)) ^ ((sum ^ y) + (k[p & 3 ^ e] ^ z)));
        }
        public static int Btea(uint[] v, int n, uint[] k)
        {
            uint z, y, sum, e, q;
            int p;

            if (n >= 1)
            {

                q = (uint)((uint)6 + 52 / n);
                sum = 0;
                z = v[n - 1];

                for (; q > 0; --q)
                {
                    sum += DELTA;
                    e = (sum >> 2) & 3;

                    for (p = 0; p < n - 1; p++)
                    {
                        y = v[p + 1];
                        z = v[p] += MX(z, y, sum, e, (uint)p, k);
                    }

                    y = v[0];
                    z = v[n - 1] += MX(z, y, sum, e, (uint)(p), k);
                }

                return 0;
            }
            else if (n < -1)
            {

                n = -n;
                q = (uint)((uint)6 + 52 / n);
                sum = q * DELTA;
                y = v[0];

                for (; q > 0; --q)
                {
                    e = (sum >> 2) & 3;

                    for (p = n - 1; p > 0; p--)
                    {
                        z = v[p - 1];
                        y = v[p] -= MX(z, y, sum, e, (uint)p, k);
                    }

                    z = v[n - 1];
                    y = v[0] -= MX(z, y, sum, e, (uint)p, k);
                    sum -= DELTA;
                }

                return 0;
            }

            return 1;
        }
    }
}
