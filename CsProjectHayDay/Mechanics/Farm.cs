using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mechanics
{
    class Farm : Building
    {
        private double generationRate;
        private int counter;//amout of current crops
        private int miniStorageCap;
        private string id;

        // Getter and setter for generationRate
        protected double GenerationRate
        {
            get { return generationRate; }
            set { generationRate = value; }
        }

        // Getter and setter for counter
        protected int Counter
        {
            get { return counter; }
            set { counter = value; }
        }

        // Getter and setter for miniStorageCap
        protected int MiniStorageCap
        {
            get { return miniStorageCap; }
            set { miniStorageCap = value; }
        }

        // Getter and setter for id
        protected string Id
        {
            get { return id; }
            set { id = value; }
        }

        public Farm()
        {

        }

        public void Move()
        {

        }
    }
}