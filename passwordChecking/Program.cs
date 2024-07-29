using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passwordChecking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = string.Empty;
            string password_check = string.Empty;

            bool doubleCheckPassword = false;
            bool checkPassword = false;
            bool checkPassword_check = false;


            // double check password!
            do
            {
                // check password
                do
                {
                    Console.Write("Enter your password \"require at least one upper case character\": ");
                    password = Console.ReadLine();
                    if (string.IsNullOrEmpty(password))
                    {
                        Console.WriteLine();
                        Console.WriteLine("Your input is null or empty, please reenter the password!");
                        continue;
                    }
                    else
                    {
                        for(int i = 0; i < password.Length - 1; ++i)
                        {
                            if (password[i] >= 'A' && password[i] <= 'Z')
                            {
                                checkPassword = true;
                                break;
                            }
                        }
                    }
                    if(!checkPassword)
                    {
                        Console.WriteLine();
                        Console.WriteLine("The password require at least one upper case character, please reenter!");
                    }
                        
                } while (!checkPassword);

                // check reenter password
                do
                {
                    Console.WriteLine();
                    Console.Write("Reenter your password: ");
                    password_check = Console.ReadLine();
                    if (string.IsNullOrEmpty(password_check))
                    {
                  
                        Console.WriteLine("Your input is null or empty, please reenter!");
                    }
                    else
                    {
                        if(string.Equals(password, password_check))
                        {
                            Console.WriteLine();
                            Console.WriteLine("Creating password successfull!");
                            checkPassword_check = true;
                            doubleCheckPassword = true;
                        }
                        else
                        {
                            
                            Console.WriteLine("The passwords do not match, please reenter!");
                        }

                    }
                        
                } while (!checkPassword_check);

            } while (!doubleCheckPassword);
            Console.ReadLine();
           
        }
    }
}
