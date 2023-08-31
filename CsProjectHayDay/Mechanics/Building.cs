using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mechanics
{
    class Building
    {
        private string img;
        private int lvl;
        private int upgradeCosts; // money
        private int slot;

        // Getter and setter for img
        protected string Img
        {
            get { return img; }
            set { img = value; }
        }

        // Getter and setter for lvl
        protected int Level
        {
            get { return lvl; }
            set { lvl = value; }
        }

        // Getter and setter for upgradeCosts
        protected int UpgradeCosts
        {
            get { return upgradeCosts; }
            set { upgradeCosts = value; }
        }

        // Getter and setter for slot
        public int Slot
        {
            get { return slot; }
            set { slot = value; }
        }

        public Building()
        {  }
           







    }
}
