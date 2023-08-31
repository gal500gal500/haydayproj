using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Mechanics
{
    class CropFarm : Farm
    {
        private const int cost = 200;//cost to buy a new cropfarm
        private static int maxGlobalLevel = 0;
        private string[] cropFarm = {"WheatFarm", "CarrotFarm", "SoyBeanFarm", "SugarCaneFarm", "CornFarm", "CuttonFarm" };
        private int[] farmerLevelToCreate = { 1, 1, 2, 3, 5, 8 };

        public int GetCost() { return cost; }

        public CropFarm(Item item) //Creats the crop and reduces the money//
        {
            this.Id = item.Id ;
            this.GenerationRate = 1;
            this.MiniStorageCap = 50;
            this.Level = 0;
            this.Img = "";
            this.Slot = -1; //event click to a free slot so it doesnt matter now
        }

        public void UpgradeFarm()
        {
            if(this.Level>=maxGlobalLevel)
                return; // how do we do the error?

            this.Level++;
            this.MiniStorageCap = (int)(1.25*this.MiniStorageCap);
            this.GenerationRate *= 1.05; //maybe we`ll change it later
        }

        public void SwitchSlot(int slot){ //
            this.Slot = slot;
        }

        ~CropFarm()// check later if we need destructor
        {
            
        }

    }
}

