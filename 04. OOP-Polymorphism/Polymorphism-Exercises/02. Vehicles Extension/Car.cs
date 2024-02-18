using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesExtension
{
    public class Car : Vehicle
    {
        private const double ConsumptionIncrease = 0.9;

        public Car(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        protected override double AdditionalConsumption => ConsumptionIncrease;
    }
}
