using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mechanics
{
    class AnimalFarm : Farm
    {
        
        private string[] animalFarm = { "Wheat", "Carrot", "Carrot", "SoyBean", "SugarCane" };
    
        private const int cost = 200;//cost to buy a new cropfarm 
        private static int maxGlobalLevel = 0; 
        private int[] farmerLevelToCreate = { 1, 1, 2, 3, 5, 8 };

        public int GetCost() { return cost; }

        public AnimalFarm(string id) //Creats the crop and reduces the money
        {
            this.Id = id;
            this.GenerationRate = 1;//we can change it to specific animals
            this.MiniStorageCap = 50;
            this.Level = 0;
            this.Img = "";
            this.Slot = -1; //we first check in world
        }
/*
        public void UpgradeFarm()
        {
            this.Level++;
            this.MiniStorageCap +=50;
            this.GenerationRate *= 1.05;
        }

        public override void SwitchSlot(){

        }

        ~CropFarm()// check later if we need destructor
        {
            
        }

*/

    }
}
