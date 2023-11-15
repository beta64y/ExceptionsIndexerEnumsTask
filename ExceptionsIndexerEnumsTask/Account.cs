using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsIndexerEnumsTask
{
    internal abstract class Account
    {
        public abstract bool PasswordChecker(string password);
        public abstract string ShowInfo();
    }
}
