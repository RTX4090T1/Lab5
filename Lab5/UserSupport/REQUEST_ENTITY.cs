using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab5.SupportInterfaces;

namespace Lab5.UserSupport
{
    public class REQUEST_ENTITY
    {
        public int ID;
        public string Issue;
        public HashSet<KEY_DATA_ENTITY> KeyData;
        public string Status = "In Progress";
        
    }
}
