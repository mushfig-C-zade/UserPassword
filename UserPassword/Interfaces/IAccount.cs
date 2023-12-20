using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserPassword.Interfaces
{
    internal interface IAccount
    {
        static abstract bool PasswordChecker(string password);
        void ShowInfo();
    }
}
