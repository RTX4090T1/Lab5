using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.LogInRegistration
{
    public class CHECK_LOGIN : ICheck
    {
        IReturn Return;
        public CHECK_LOGIN(IReturn _return) { Return = _return;}

        public bool CheckData(string email, string password)
        {
            if(Return.Ireturn().Where(em => em.Email == email).Any(pass => pass.Password == password))
            {return true;}
            return false;
        }
    }
}
