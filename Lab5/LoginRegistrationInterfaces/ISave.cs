using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.LogInRegistration
{
    public interface ISave
    {
        void SaveData(string email, string password);
    }
}
