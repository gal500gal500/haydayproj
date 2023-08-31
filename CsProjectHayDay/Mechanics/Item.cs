using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mechanics
{
    class Item
    {
        private string id;
        private string recpie;
        private string img;
        private string name;

        public Item(string id, string recpie, string img, string name)
        {
            this.id = id;
            this.name = name;
            this.recpie = recpie;
            this.img = img;
        }

        public string Id
        {
            get
            {
                return this.id;
                    }
        }
    }
}
