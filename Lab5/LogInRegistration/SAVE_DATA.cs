using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.LogInRegistration
{
    public class SAVE_DATA:ISave
    {
        IReturn CheckLogin;
        public SAVE_DATA(IReturn checkLogin){CheckLogin = checkLogin;}
        public void SaveData(string email, string password)
        {
            CheckLogin.Ireturn().Add(new LOGIN_ENTITY { Email = email, Password = password });
        } 
    }
}
