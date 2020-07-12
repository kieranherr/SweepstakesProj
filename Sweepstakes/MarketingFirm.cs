using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
    class MarketingFirm
    {
        public ISweepstakesManager SweepManager;
        public MarketingFirm(ISweepstakesManager sweepstakesManager)
        {
            SweepManager = sweepstakesManager;
        }
        public void NewSweep(string SweepName)
        {
            SweepManager.InsertSweepstakes(UserInterface.NewSweep(SweepName));
        }
    }
}
