using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Mechanics
{

     class Storage : Building
{
    private int siloCap;    // capacity
     private int capBarn; 
    private string[] totalSilo;
    private string[] totalBarn;  //an array of the amount of items that are stored. we will not create new Items everytime we will use the once in world the format is "Id-amount" 

    protected int SiloCap
    {
        get { return siloCap; }
        set { siloCap = value; }
    }
        protected int BarnCap
    {
        get { return siloCap; }
        set { siloCap = value; }
    }
        public void PrintAllItems()
    {
        
    }
   
}
}