using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyVirtualPatternDemo
{
    class Hero : IVisitor
    {
        private int damage = 25;

        public int attacks(Wolf wolf)
        {
            if (wolf.Race == Races.Magic)
            {
                return wolf.Health = (damage - (wolf.Armor / 2) + 10); //10 extra damage because race is magic and hero does more damage to magic
            } else if (wolf.Race == Races.Earth)
            {
                return wolf.Health = (damage - (wolf.Armor / 2) - 5);
                    //5 extra damage because race is earth and hero does less damage to earth
            }
            else
            {
                return wolf.Health;
            }
        }

        public int attacks(MagicFrog magicFrog)
        {
            if (magicFrog.Race == Races.Magic)
            {
                return magicFrog.Health = (damage - (magicFrog.Armor / 2) + 10); //10 extra damage because race is magic and hero does more damage to magic
            }
            else if (magicFrog.Race == Races.Earth)
            {
                return magicFrog.Health = (damage - (magicFrog.Armor / 2) - 5);
                //5 extra damage because race is earth and hero does less damage to earth
            }
            else
            {
                return magicFrog.Health;
            }
        }
    }
}
