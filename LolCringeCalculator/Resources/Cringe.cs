using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Timers;

namespace LolCringeCalculator.Resources
{
    class Cringe
    {
        System.Timers.Timer timer;

        public Cringe(int waveInterval)
        {
            minion SiegeMinion = new minion(1, 60);
            minion MeleeMinion = new minion(3, 21);
            minion CasterMinion = new minion(3, 14);
            timer.Elapsed += Wave;
        }

        private void Wave(object sender, ElapsedEventArgs e)
        {
            throw new NotImplementedException();
        }

        public void start()
        {
            timer.Start();
        }

        public void change(int level)
        {
            switch (level)
            {
                case 1:

                    break;

                case 2:


                    break;


                case 3:


                    break;

                case 4:


                    break;
            }
        }
    }
}
