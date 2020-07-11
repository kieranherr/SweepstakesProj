using System;
<<<<<<< HEAD
=======
using System.Collections;
>>>>>>> Sweepstakes
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
    class SweepstakesStackManager : ISweepstakesManager
    {
<<<<<<< HEAD
        public SweepstakesStackManager()
        {

=======
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
>>>>>>> Sweepstakes
        }
    }
}
