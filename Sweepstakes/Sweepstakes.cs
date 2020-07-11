using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Sweepstakes
{
    
    class Sweepstakes
    {
        public string sweepName;
        public Dictionary<string, Contestant> dict;
        public Sweepstakes(string name)
        {
            dict = new Dictionary<string, Contestant>();
            sweepName = name;
        }
        public void RegisterContestant(Contestant contestant)
        {
            dict.Add(contestant.regNum, contestant);
        }
        public Contestant PickWinner()
        {
            Random rnd = new Random();
            int winner = rnd.Next(0, dict.Count - 1);
            return dict.ElementAt(winner).Value;
        }
        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine("The winner is Contestant number: " + contestant.regNum);
        }
    }
}
