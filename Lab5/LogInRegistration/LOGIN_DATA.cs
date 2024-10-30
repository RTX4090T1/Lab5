using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.LogInRegistration
{
    public class LOGIN_DATA:IReturn
    {
        public List<LOGIN_ENTITY> data = new List<LOGIN_ENTITY>();
        public LOGIN_DATA() { }

        public List<LOGIN_ENTITY> Ireturn()
        {
            return data;
        }
    }
}
