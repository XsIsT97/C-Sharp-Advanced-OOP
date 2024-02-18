using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiding
{
    public class Druid : BaseHero
    {
        private const int DefaultPower = 80;
        public Druid(string name, string type)
            : base(name, type)
        {
        }

        public override int Power => DefaultPower;

        public override string CastAbility()
        {
            return $"{this.GetType().Name} - {Name} healed for {Power}";
        }
    }
}
