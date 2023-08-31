using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace Mechanics
{
    class SiloStorage:Storage
    {
        private int[] collector ;

        protected SiloStorage(int gal){
            
            this.collector = new int[gal];
            for(int i =0; i <gal; i++)
                this.collector[i] = 0;

        }

        protected void Add(string id, int amount){ //
            int index = int.Parse("");

        }

    }
}
