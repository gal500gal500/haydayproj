using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mechanics
{
    class World
    {
        private bool[] CropsSlots;
        private bool[] AnimalsSlots;
        private int maxCropFarmLevel;
        private Item[] allItems;


        public World()
        {
            int items = 3;
            this.maxCropFarmLevel = 1;
            this.CropsSlots = new bool[18];
            this.AnimalsSlots = new bool[8];  
            for(int i = 0;i < 18; i++)
                this.CropsSlots[i] = false;
            for(int i = 0; i < 18; i++)
                this.AnimalsSlots[i] = false;     
            this.allItems = new Item[items];
            //continue later
        }
    }
}
