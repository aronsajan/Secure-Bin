#region Author : Aron Sajan Philip
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SecureBinCore.Validation
{
    class PasswordValidation : Validate
    {
        string Password;
        public PasswordValidation(string password)
        {
            Password = password;
        }
        public override void ValidateData()
        {
            if (Password.Length < 8)
            {
                throw (new ApplicationException("Password is less than 8 characters in length"));
            }
            if (Password.Length > 16)
            {
                throw (new ApplicationException("Password is more than 16 characters in length"));
            }
        }

    }
}

#endregion