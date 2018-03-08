using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountMock
{
    public class Account
    {
        private bool _active = false;
        private int? _accountId = null;
        public string userName { get; set; }
        public string password { get; set; }
        public int balance { get; set; }

        public void setStatus(bool status, Account account)
        {
            account._active = status;
        }

        public bool Validate()
        {            
            List<char> restrictedChars = new List<char>() {'@','#','%','^','&','(',')','+'};
            
            if ((userName != null) && (password != null))
            {
                if ((userName != "") && (password != ""))
                {
                    if ((userName.Length < 25) && (password.Length < 25))
                    {
                        _active = true;                   
                    }
                }
            }

            foreach (var element in userName)
            {
                foreach (var item in restrictedChars)
                {
                    if (element == item)
                    {
                        _active = false;
                    }
                }
            }
            return _active;
        }

        public bool isActive()
        {
            if (_active)
            {
                return true;
            }
            return false;
        }

        public int? setAccountId(int accountId, Account account)
        {
            if (account.isActive())
            {    
                account._accountId = accountId;
            }
            return account._accountId;
        }

        public int? getAccountId(Account account)
        {
            return account._accountId;
        }

        public int? setAccountId(string accountId, Account account)
        {
            if (account.isActive())
            {
                if (string.IsNullOrWhiteSpace(accountId.ToString()))
                {
                    return null;
                }
                else
                {
                    account._accountId = int.Parse(accountId);
                }
            }
            return account._accountId;
        }
    }


    


}
