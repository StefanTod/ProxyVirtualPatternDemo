﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyVirtualPatternDemo
{
    class Mage : IVisitor
    {
        private int damage = 20;

        public int attacks(Wolf wolf)
        {
            Wolf wf = wolf;
            return wf.Health -= calculateDmg(wf.Race, damage, wf.Armor, wf.MagicResistance);
        }

        public int attacks(MagicFrog magicFrog)
        {
            MagicFrog mf = magicFrog;
            return mf.Health -= calculateDmg(mf.Race, damage, mf.Armor, mf.MagicResistance);
        }

        public int calculateDmg(Races race, int damage, int armor, int magicResistance)
        {
            switch (race)
            {
                case Races.Magic:
                    return (damage - (armor / 2) - 5); //5 less damage because race is magic and hero does less damage to magic
                case Races.Earth:
                    return (damage - (armor / 2) + 10); //10 extra damage because race is earth and mage does more damage to earth

                default:
                    return 0;
            }
        }
    }
}
