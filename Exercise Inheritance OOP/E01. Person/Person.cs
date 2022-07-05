﻿
namespace Person
{
    public class Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name 
        {
            get 
            {
                // Use fields, never with properties
                return this.name;
            }
            set 
            {
                this.name = value;
            } 
        }

        public int Age 
        {
            get 
            {
                return this.age;
            }
            set 
            {
                if (value < 0)
                {
                    this.age = 0;
                }
                else
                {
                    this.age = value;
                }
            }
        }

        public override string ToString()
        {
            return $"Name: {this.Name}, Age: {this.Age}";
        }
    }
}
