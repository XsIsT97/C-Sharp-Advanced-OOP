using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShortage
{
    public class Pet : IBirthable
    {
        private string name;
        private string birthable;

        public Pet(string name, string birthable)
        {
            Name = name;
            Birthable = birthable;
        }

        public string Name 
        {
            get { return name; }
            set { name = value; }
        }
        public string Birthable 
        {
            get { return birthable; }
            set { birthable = value; }
        }

    }
}
