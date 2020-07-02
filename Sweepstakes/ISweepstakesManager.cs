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
        }
    }
}
