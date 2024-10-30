using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab5.SupportInterfaces;

namespace Lab5.UserSupport
{
    public class PAYMENT_ISSUES: IReturnForSupport
    {
        List<REQUEST_ENTITY> PaymentIssues = new List<REQUEST_ENTITY>();
        public PAYMENT_ISSUES()
        {
          
            
        }
        public List<REQUEST_ENTITY> Return() { return instance.PaymentIssues; }
        private static PAYMENT_ISSUES instance = null;
       public static PAYMENT_ISSUES GetInstance()
        {
            if (instance == null)
            {
                instance = new PAYMENT_ISSUES();
            }
            return instance;
        }
    }
}
