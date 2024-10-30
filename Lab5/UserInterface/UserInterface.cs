using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab5.UserActionHandler;
using Lab5.LogInRegistration;
using Lab5.SupportInterfaces;
using Lab5.UserSupport;

namespace Lab5.UserInterface
{
    internal class UserInterface
    {
        static void Main(string[] args)
        {
            USER_ACTION_HANDLER handler = new USER_ACTION_HANDLER();
            int startEnd;
            int action;
            bool result;
            HashSet<KEY_DATA_ENTITY> users = new HashSet<KEY_DATA_ENTITY>();
            do
            {
                Console.WriteLine("Enter 1 to continue and else to finish: ");
                startEnd = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter 1 to register new accaunt" +
                                    " 2 to log in with your accaunt" +
                           " 3 see all request history(ADMIN ONLY): ");
                action = Convert.ToInt32(Console.ReadLine());
                switch (action)
                {
                    case 1:
                        Console.WriteLine("Enter new email: ");
                        string newEmail = Console.ReadLine();
                        Console.WriteLine("Enter new password: ");
                        string newPassword = Console.ReadLine();
                        handler.Registraton(newEmail, newPassword);
                        break;
                    case 2:
                        Console.WriteLine("Enter your email: ");
                        string email = Console.ReadLine();
                        Console.WriteLine("Enter your password: ");
                        string password = Console.ReadLine(); 
                        result = handler.LogIn(email, password);
                        if (result != true)
                        {
                            Console.WriteLine("Log in or register new accaunt to continue");
                            break;
                        }
                        Console.WriteLine("Describe your issue: ");
                        string issue = Console.ReadLine();
                        Console.WriteLine("Enter key info: ");
                        string keyInfo = Console.ReadLine();
                        users.Add(new KEY_DATA_ENTITY { OS = keyInfo });
                        handler.CallSupportCentre(users, issue);
                        break;
                    case 3:
                        Console.WriteLine("Enter password to get issues history: ");
                        string pass = Console.ReadLine();
                        handler.GetHistory(pass);
                        break;
                    default:
                        Console.WriteLine("Incorrect operation.");
                        break;
                }
            } while(startEnd == 1);     
        }
    }
}
