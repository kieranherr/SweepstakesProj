using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
   
        public interface ISweepstakesManager
        {
            void InsertSweepstakes(Sweepstakes sweepstakes);
        Sweepstakes GetSweepstakes();
        bool IsSweepstakes();

        bool IsContestant();
        }
        
       
        
    
}