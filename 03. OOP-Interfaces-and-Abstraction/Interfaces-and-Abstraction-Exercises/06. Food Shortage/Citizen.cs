using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShortage
{
    public class Citizen : IIdentifiable, IBirthable, IBuyer
    {
        private const int DefaultFoodPortion = 10;

        private string name;
        private int age;
        private string id;
        private string birthable;
        private int food = 0;
        public Citizen(string name, int age, string id, string birthable)
        {
            Name = name;
            Age = age;
            Id = id;
            Birthable = birthable;
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
        public string Id 
        {
            get { return id; }
            set { id = value; }
        }
        public string Birthable 
        {
            get { return birthable; }
            set { birthable = value; }
        }
        
        public int Food => food;
        public void BuyFood()
        {
            this.food += DefaultFoodPortion;
        }
    }
}
