using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mechanics
{
    class Farmer
    {
        private int level;
        private int gems;
        private int money;
        public World world;

        public int getLevel() { return this.level; }
        public int getMoney() { return this.money; }
        public int getGems() { return this.gems; }
        public void AddGems(int gems) { this.gems += gems; }
        public void RemoveGems(int gems) { this.gems -= gems; }
        public void Addoney(int money) { this.money += money; }
        public void RemoveMoney(int money) { this.money -= money; }
        public void AddLevel(int level) { this.level++; }

        public CropFarm NewCropFarm(Item crop) //Creats the crop and reduces the money, returns the object to the array
        {
            CropFarm test = new CropFarm(crop);
            this.money -= test.GetCost(); //add if to check if the guy has enogth money to buy it
            return test;
        }

        public void SwitchCropSlot() //world array
        {
          
        }

        public void SwitchAnimalSlot() //world array
        {
          
        }
        public void SwitchMachineSlot() //world array
        {
          
        }
        public void SwitchStorageSlot() //world array
        {
          
        }


    }

}