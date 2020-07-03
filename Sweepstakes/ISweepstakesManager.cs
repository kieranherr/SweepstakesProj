using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
    class ISweepstakesManager
    {
        public ISweepstakesManager()
        {
           
        }
        
        interface ISweeptakes
        {
            void InsertSweepstakes(Sweepstakes sweepstakes);
        }
        class Sweepstake : ISweepstakesManager
        {
            Sweepstakes GetSweepstakes()
            {
                string name ="";
                Sweepstakes sweepstakes = new Sweepstakes(name);
                return sweepstakes;

            }
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

        }
    }
}
