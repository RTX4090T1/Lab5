using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab5.UserActionHandler;
using Lab5.LogInRegistration;
using Lab5.SupportInterfaces;

namespace Lab5.UserSupport
{
    public class ID_GENERATOR:IIDgenerator
    {   
        Random random = new Random();
        IReturnForSupport Return;
        public ID_GENERATOR(IReturnForSupport _return){Return = _return;}  

        public int GenerateID()
        {
            int from = 100;
            int to = 102; 
            int randomNumber = random.Next(0, to);
            foreach(REQUEST_ENTITY id in Return.Return())
            {
                to++;
                from++;
            }
            return randomNumber;
        }
    }
}
