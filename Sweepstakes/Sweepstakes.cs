using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
    
    class Sweepstakes
    {
        public string sweepName;
        
        public Sweepstakes(string name)
        {
            sweepName = name;
        }
        public void RegisterContestant(Contestant contestant)
        {

        }
        public Contestant PickWinner()
        {
            Contestant contestant = new Contestant();
            return contestant; 
        }
        public void PrintContestantInfo(Contestant contestant)
        {

        }
    }
}
