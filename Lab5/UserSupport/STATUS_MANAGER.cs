using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab5.SupportInterfaces;

namespace Lab5.UserSupport
{
    public class STATUS_MANAGER:IStatusManager
    {
        public void ManageIssueStatus(REQUEST_ENTITY issue)
        {
            issue.Status = "Completed";
            Console.WriteLine($"Your issue ID: {issue.ID}");
            Console.WriteLine($"Your issue status: {issue.Status}");
        }
    }
}
