using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mechanics
{
     class Storage : Building
{
    private int cap;    // storage for crop
    private int count;  //curr amount in storage

    protected int Cap
    {
        get { return cap; }
        set { cap = value; }
    }

    protected int Count
    {
        get { return count; }
        set { count = value; }
    }

    

}
}