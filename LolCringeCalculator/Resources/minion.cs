using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace LolCringeCalculator.Resources
{
    class minion
    {
       
        private int _armour;
        public int armour
        {
            get { return _armour; }
            set { _armour = value; }
        }

        private int _MR;

        public int MagicResistance
        {
            get { return _MR; }
            set { MagicResistance = value; }
        }

        private int _healt;

        public int healt
        {
            get { return _healt; }
            set { _healt = value; }
        }

        private int _AD;
        
        public int Ad
        {
            get { return _AD; }
            set { _AD = value; }
        }

        private int _AP;

        public int Ap
        {
            get { return _AP;  }
            set { _AP = value; }
        }

        private int goldValue;

        public int spawned;

        private int maxnumber;


        private int actuals;

        public minion(int maxnumber, int goldValue)
        {
            this.maxnumber = maxnumber;
            this.goldValue = goldValue;
        }

        public int kill()
        {
            actuals = 0;
            return this.goldValue * maxnumber;
        }

        public void spawn()
        {
            actuals = maxnumber;
            spawned = spawned + actuals;
        }

        public void setGold(int goldValue)
        {
            this.goldValue = goldValue;
        }


    }
}

 

