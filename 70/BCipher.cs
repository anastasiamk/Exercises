using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _70
{
    class BCipher : ICipher
    {
        public string S { get; set; }
        public virtual string encode()
        {
            string k = "";
            for (int i = 0; i < S.Length; i++)
            {
                if(((int)S[i] >= 65 && (int)S[i] <= 90))
                    k += (char)(90 - ( (int)S[i] - 65 )) ;

                if(((int)S[i] >= 97 && (int)S[i] <= 122))
                    k += (char)(122 - ((int)S[i] - 97));
                if (((int)S[i] >= 1040 && (int)S[i] <= 1071))
                    k += (char)(1071 - ((int)S[i] - 1040));
                if (((int)S[i] >= 1072 && (int)S[i] <= 1103))
                    k += (char)(1103 - ((int)S[i] - 1072));
            }
            return k;
        }
        public virtual string decode()
        {
            string k = "";
            for (int i = 0; i < S.Length; i++)
            {
                if (((int)S[i] >= 65 && (int)S[i] <= 90))
                    k += (char)(65 - ((int)S[i] - 90));

                if (((int)S[i] >= 97 && (int)S[i] <= 122))
                    k += (char)(97 - ((int)S[i] - 122 ));

                if (((int)S[i] >= 1040 && (int)S[i] <= 1071))
                    k += (char)(1040 - ((int)S[i] - 1071));

                if (((int)S[i] >= 1072 && (int)S[i] <= 1103))
                    k += (char)(1072 - ((int)S[i] - 1103));
            }
            return k;

        }
    }
}
