using Lab5.SupportInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.UserSupport
{
    public class REDIRECT_TO_SOLVER:IRedirectableToSolver
    {
        IIssueSolverable Redirect;
        IReturnForSupport ReturnForSupport;
        public REDIRECT_TO_SOLVER(IIssueSolverable redirect,IReturnForSupport returnForSupport)
        {   
            Redirect = redirect;
            ReturnForSupport = returnForSupport;
        }     
        public void RedirectToSolver()
        {
            foreach(REQUEST_ENTITY issue in ReturnForSupport.Return())
            {
                if (issue.Status != "Completed")
                {
                    Redirect.SolveIssue(issue);
                    Console.WriteLine("We solving your issue...");
                }               
            }
        }
    }
}
