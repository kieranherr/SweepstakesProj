using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
    class SweepstakesQueueManager : ISweepstakesManager
    {

  
        Queue<Sweepstakes> myQueue;
        public SweepstakesQueueManager()
        {
            myQueue = new Queue<Sweepstakes>();

        }
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            myQueue.Enqueue(sweepstakes);
        }
        public Sweepstakes GetSweepstakes()
        {
            return myQueue.Dequeue();
        }
        public bool IsContestant()
        {
            Sweepstakes sweepstakes = myQueue.Peek();
            if (sweepstakes.dict.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool IsSweepstakes()
        {
            if (myQueue.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
       
    }
}
