using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShortage
{
    public class Rebel : IBuyer
    {
        private const int DefaultFoodPortion = 5;

        private string name;
        private int age;
        private string group;
        private int food = 0;

        public Rebel(string name, int age, string group)
        {
            Name = name;
            Age = age;
            Group = group;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Group
        {
            get { return group; }
            set { group = value; }
        }


        public int Food => food;
        public void BuyFood()
        {
            this.food += DefaultFoodPortion;
        }
    }
}
