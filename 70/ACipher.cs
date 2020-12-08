using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _70
{
    class ACipher : ICipher
    {
        public string S { get; set; }
        public virtual string encode()
        {
            string k = "";
            for (int i = 0; i < S.Length; i++)
                k += (char)((int)S[i] + 1);
                
            return k;
        }
        public virtual string decode()
        {
            string k = "";
            for (int i = 0; i < S.Length; i++)
                k += (char)((int)S[i] - 1);
            return k;

        }
    }
}
