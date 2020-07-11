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
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            myStack.Push(sweepstakes);
        }
        public Sweepstakes GetSweepstakes()
        {
            return myStack.Pop();
        }
        public bool IsContestant()
        {
            Sweepstakes sweepstakes = myStack.Peek();
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
            if (myStack.Count == 0)
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
