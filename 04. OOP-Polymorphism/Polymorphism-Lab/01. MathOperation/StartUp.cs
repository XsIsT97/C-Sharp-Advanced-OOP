using System;

namespace MathOperation
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            MathOperation operations = new MathOperation();

            Console.WriteLine(operations.Add(2, 3));
            Console.WriteLine(operations.Add(2.2, 3.3, 5.5));
            Console.WriteLine(operations.Add(2.2m, 3.3m, 4.4m));
        }
    }
}
