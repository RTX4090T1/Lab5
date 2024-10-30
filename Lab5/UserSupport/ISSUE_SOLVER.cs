using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab5.SupportInterfaces;

namespace Lab5.UserSupport
{
    public class ISSUE_SOLVER:IIssueSolverable
    {
        IStatusManager Status;
        public ISSUE_SOLVER(IStatusManager status){Status = status;}
        
        public void SolveIssue(REQUEST_ENTITY issue)
        {
            IssueSolving(issue);
        }
        public async void IssueSolving(REQUEST_ENTITY issue)
        {
            await Task.Delay(30000);
            Status.ManageIssueStatus(issue);
        }
    }
}
