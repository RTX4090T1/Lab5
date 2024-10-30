using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab5.SupportInterfaces;

namespace Lab5.UserSupport
{
    public class SEND_ISSUE_DATA:ISendIssueData
    {
        IReturnForSupport Return;
        public SEND_ISSUE_DATA(IReturnForSupport _return)
        {
            Return = _return;
        }
        public void SendData(int id, HashSet<KEY_DATA_ENTITY> keyData, string issue)
        {
            Return.Return().Add(new REQUEST_ENTITY {ID = id,KeyData = keyData, Issue = issue});
        }
    }
}
