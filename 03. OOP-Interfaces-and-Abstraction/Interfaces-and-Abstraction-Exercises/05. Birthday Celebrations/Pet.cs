using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayCelebrations
{
    public class Pet : IBirthable
    {
        private string name;
        private string birthday;

        public Pet(string name, string birthday)
        {
            Name = name;
            Birthday = birthday;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }
    }
}
