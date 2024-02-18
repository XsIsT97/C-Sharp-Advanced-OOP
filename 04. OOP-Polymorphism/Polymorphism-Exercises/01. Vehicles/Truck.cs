using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Truck : Vehicle
    {
        private const double ConsumtionIncrease = 1.6;
        private const double PercentageOfFuelRefueled = 0.5;

        public Truck(double fuelQuantity, double fuelConsumption)
            : base(fuelQuantity, fuelConsumption)
        {

        }

        protected override double AdditionalConsumption => ConsumtionIncrease;

        public override void Refuel(double fuel)
        {
            fuel *= PercentageOfFuelRefueled;
            base.Refuel(fuel);
        }
    }
}
