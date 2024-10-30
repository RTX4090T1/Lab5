using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using Lab5.LogInRegistration;
using Lab5.SupportInterfaces;
using Lab5.UserSupport;

namespace Lab5.UserActionHandler
{
    public class USER_ACTION_HANDLER
    {
        IReturn iReturn;
        ISave iSave;
        ICheck iCheck;

        REGISTRATION_CHECK RegistrationCheck;
        CHECK_LOGIN CheckLogin;
        SAVE_DATA SaveData;

        IGetIssueData iGetIssueData;
        IIssueSolverable issueSolver;
        IRedirectableToSolver iredirectableToSolver;
        IReturnForSupport iReturnForSupport;
        ISendIssueData iSendIssueData;
        IStatusManager iStatusManager;
        IIDgenerator iIDgenerator;

        GET_ISSUE_DATA GetIssueData;
        ISSUE_SOLVER IssueSolver;
        PAYMENT_ISSUES paymentIssue;
        REDIRECT_TO_SOLVER RedirectToSolver;
        SEND_ISSUE_DATA SendIssueData;
        STATUS_MANAGER StatusManager;
        REQUEST_ENTITY RequestENtity;
        ID_GENERATOR IDgenerator;


        public USER_ACTION_HANDLER()
        {
            iReturn = new LOGIN_DATA();
            iSave = new SAVE_DATA(iReturn);
            iCheck = new REGISTRATION_CHECK(iSave, iReturn);

            SaveData = new SAVE_DATA(iReturn);
            RegistrationCheck = new REGISTRATION_CHECK(iSave, iReturn);
            CheckLogin = new CHECK_LOGIN(iReturn);

            iReturnForSupport = PAYMENT_ISSUES.GetInstance();
            iSendIssueData = new SEND_ISSUE_DATA(iReturnForSupport);
            iGetIssueData = new GET_ISSUE_DATA(iSendIssueData);
            iStatusManager = new STATUS_MANAGER();
            issueSolver = new ISSUE_SOLVER(iStatusManager);
            iredirectableToSolver = new REDIRECT_TO_SOLVER(issueSolver, iReturnForSupport);
            iIDgenerator = new ID_GENERATOR(iReturnForSupport);

            paymentIssue = PAYMENT_ISSUES.GetInstance();
            SendIssueData = new SEND_ISSUE_DATA(iReturnForSupport);
            GetIssueData = new GET_ISSUE_DATA(iSendIssueData);
            StatusManager = new STATUS_MANAGER();
            IssueSolver = new ISSUE_SOLVER(iStatusManager);
            RedirectToSolver = new REDIRECT_TO_SOLVER(issueSolver, iReturnForSupport);
            RequestENtity = new REQUEST_ENTITY();
            IDgenerator = new ID_GENERATOR(iReturnForSupport);
        }
        public bool Registraton(string email, string password)
        {
            if(RegistrationCheck.CheckData(email, password))
            {
                Console.WriteLine("Accoun created successfully.");
                SaveData.SaveData(email, password);
                return true;
            }
            Console.WriteLine($"Email: {email} already exists.\nPassword must conbtain at least 8 symbols.");

            return false;
        }
        public bool LogIn(string email, string password)
        {
            if(CheckLogin.CheckData(email, password))
            {
                Console.WriteLine($"You logined as: {email}");
                return true;
            }
            Console.WriteLine($"There is no such accaunt as: {email}");
            return false;
        }
        public void CallSupportCentre(HashSet<KEY_DATA_ENTITY> keyData, string issue )
        {
            GetIssueData.GetIssueData(IDgenerator.GenerateID(), keyData, issue);
            RedirectToSolver.RedirectToSolver();
        }
        public void GetHistory(string password)
        {
            if (password == "123")
            {
                foreach (REQUEST_ENTITY issue in paymentIssue.Return())
                {
                    Console.WriteLine($"ID: {issue.ID}");
                    Console.WriteLine($"Key data: {issue.KeyData}");
                    Console.WriteLine($"Issue: {issue.Issue}");
                }
            }
            else
            {
                Console.WriteLine("Incorrect Password");
            }
        }
    }
}
