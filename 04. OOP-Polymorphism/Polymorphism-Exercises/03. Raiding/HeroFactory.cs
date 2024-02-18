using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiding
{
    static class HeroFactory
    {
        public static BaseHero CreateHero(string name, string type)
        {
            if (type == "Druid")
            {
                return new Druid(name, type);
            }
            else if (type == "Paladin")
            {
                return new Paladin(name, type);
            }
            else if (type == "Rogue")
            {
                return new Rogue(name, type);
            }
            else if (type == "Warrior")
            {
                return new Warrior(name, type);
            }
            else
            {
                throw new ArgumentException("Invalid hero!");
            }
        }
    }
}
