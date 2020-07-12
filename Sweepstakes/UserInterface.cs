using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Sweepstakes
{
  
    class UserInterface
    {
        static int Register = 0;
        public static string FirstName()
        {
            Console.WriteLine("What is your first name?");
            return Console.ReadLine();
        }

        public static string LastName()
        {
            Console.WriteLine("What is your last name?");
            return Console.ReadLine();
        }

        public static string Email()
        {
            Console.WriteLine("What is your email?");
            return Console.ReadLine();  
        }

        public static int YourNum()
        {
            Register++;
            Console.WriteLine("Your number is: " + Register);
            return Register; 
                }

        public static int ClearNum()
        {
            Register = 0;
            return Register;
        }
        public static Sweepstakes NewSweep(string nameOfSweep)
        {
            return new Sweepstakes(nameOfSweep);
        }
    }

}

