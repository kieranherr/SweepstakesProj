using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
    class SweepstakesStackManager : ISweepstakesManager
    {

        Stack<Sweepstakes> myStack;
        public SweepstakesStackManager()
        {
            myStack = new Stack<Sweepstakes>();
        }
        public void NewSweepstakes(Sweepstakes sweepstakes)
        {
            myStack.Push(sweepstakes);
        }

        public Sweepstakes GetSweepstakes(Sweepstakes sweepstakes)
        {
            return myStack.Pop();

        }
    }
}
