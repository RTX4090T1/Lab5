using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab5.SupportInterfaces;

namespace Lab5.UserSupport
{
    public class GET_ISSUE_DATA:IGetIssueData
    {
        ISendIssueData SendissueData;
        public GET_ISSUE_DATA(ISendIssueData sendissueData) { SendissueData = sendissueData; }

        public void GetIssueData(int id, HashSet<KEY_DATA_ENTITY> keyData,string issue)
        {
            SendissueData.SendData(id, keyData, issue);
        }
    }
}
