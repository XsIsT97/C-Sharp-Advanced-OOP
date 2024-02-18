using System.Linq.Expressions;
using WildFarm.Animals;

namespace WildFarm.Factories
{
    public static class AnimalFactory
    {
        public static Animal CreateAnimal(params string[] data)
        {
            string type = data[0];
            string name = data[1];
            double weight = double.Parse(data[2]);

            if (type == "Owl")
            {
                double wingSize = double.Parse(data[3]);
                return new Owl(name, weight, wingSize);
            }
            else if (type == "Hen")
            {
                double wingSize = double.Parse(data[3]);
                return new Hen(name, weight, wingSize);
            }
            else if (type == "Mouse")
            {
                string livingRegin = data[3];
                return new Mouse(name, weight, livingRegin);
            }
            else if (type == "Dog")
            {
                string livingRegion = data[3];
                return new Dog(name, weight, livingRegion);
            }
            else if (type == "Cat")
            {
                string livingRegion = data[3];
                string breed = data[4];
                return new Cat(name, weight, livingRegion, breed);
            }
            else if (type == "Tiger")
            {
                string livingRegion = data[3];
                string breed = data[4];
                return new Tiger(name, weight, livingRegion, breed);
            }
            else
            {
                return null;
            }
        }
    }
}
