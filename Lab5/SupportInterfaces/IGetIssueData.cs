using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.UserSupport
{
    public interface IGetIssueData
    {
        void GetIssueData(int id, HashSet<KEY_DATA_ENTITY> keyData, string issue);
    }
}
