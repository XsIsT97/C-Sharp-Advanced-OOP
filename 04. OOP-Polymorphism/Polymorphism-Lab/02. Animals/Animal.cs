using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Animal
    {
        private string name;
        private string favouritFood;

        public Animal(string name, string favouritFood)
        {
            Name = name;
            FavouritFood = favouritFood;
        }

        public string Name 
        {
            get { return name; }
            set { name = value; }
        }
        public string FavouritFood 
        {
            get { return favouritFood; }
            set {favouritFood = value; }
        }

        public virtual string ExplainSelf()
        {
            return $"I am {Name} and my favourite food is {FavouritFood}";
        }
    }
}
