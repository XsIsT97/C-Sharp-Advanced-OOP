using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesExtension
{
    public abstract class Vehicle
    {
        private double fuelQuantity;
        private double fuelConsumption;
        private double tankCapacity;
        protected Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
            TankCapacity = tankCapacity;
        }

        public double FuelQuantity 
        {
            get => fuelConsumption;
            protected set
            {
                if (value > TankCapacity)
                {
                    fuelQuantity = 0;
                }
                else
                {
                    fuelQuantity = value;
                }
            }
        }

        public double FuelConsumption 
        {
            get => fuelConsumption;
            private set => fuelConsumption = value;
        }

        public double TankCapacity 
        {
            get => tankCapacity;
            set => tankCapacity = value;
        }

        protected abstract double AdditionalConsumption { get; }

        public virtual void Refuel(double fuel)
        {
            if (fuel <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }

            if (FuelQuantity + fuel > tankCapacity)
            {
                throw new ArgumentException($"Cannot fit {fuel} fuel in the tank");
            }

            FuelQuantity += fuel;
        }

        public string Drive(double kilometers)
        {
            double fuelNeeded = (FuelConsumption + AdditionalConsumption) * kilometers;

            if (fuelNeeded <= FuelQuantity)
            {
                fuelQuantity -= fuelNeeded;
                return $"{this.GetType().Name} traveled {kilometers} km";
            }
            else
            {
                return $"{this.GetType().Name} needs refueling";
            }
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:F2}";
        }
    }
}
