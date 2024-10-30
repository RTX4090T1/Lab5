using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.LogInRegistration
{
    public class REGISTRATION_CHECK : ICheck
    {
        ISave Save;
        IReturn Return;
        public REGISTRATION_CHECK(ISave save,IReturn _return){ Save = save; Return = _return; }
        public bool CheckData(string email, string password)
        {
            if(Return.Ireturn().Any(em => em.Email == email) || Return.Ireturn().Any(pass => pass.Password.Count() < 8))
            {
                return false;
            }
            Save.SaveData(email,password);
            return true;
        }
    }
}
