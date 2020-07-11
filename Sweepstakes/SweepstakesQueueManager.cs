using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
    class SweepstakesQueueManager : ISweepstakesManager
    {
<<<<<<< HEAD
        public SweepstakesQueueManager()
        {

=======
        Queue<Sweepstakes> myQueue;
        public SweepstakesQueueManager()
        {
            myQueue = new Queue<Sweepstakes>();
>>>>>>> Sweepstakes
        }
    }
}
