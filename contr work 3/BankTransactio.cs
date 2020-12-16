using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contr_work_3
{
    class BankTransactio : BankAccount
    {
        public readonly DateTime dt;
        public BankTransactio()
        {
            dt = DateTime.Now;
        }

    }
}
