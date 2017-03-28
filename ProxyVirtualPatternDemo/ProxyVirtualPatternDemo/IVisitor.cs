using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyVirtualPatternDemo
{
    interface IVisitor
    {
        int attacks(Wolf wolf);
        int attacks(MagicFrog magicFrog);
        int calculateDmg(Races race, int damage, int armor, int magicResistance);
    }
}
