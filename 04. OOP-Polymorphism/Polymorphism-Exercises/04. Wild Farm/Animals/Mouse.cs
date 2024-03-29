﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Food;

namespace WildFarm.Animals
{
    public class Mouse : Mammal
    {
        public Mouse(string name, double weight, string livingRegion)
            : base(name, weight, livingRegion)
        {
        }

        public override double WeightGainPerUnitOfFood => 0.10;

        public override void Feed(Food food)
        {
            if (!(food is Vegetable) && !(food is Fruit))
            {
                throw new ArgumentException($"{GetType().Name} does not eat {food.GetType().Name}!");
            }

            base.Feed(food);
        }

        public override string ProduceSound()
        {
            return "Squeak";
        }
    }
}
