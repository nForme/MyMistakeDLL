using System;
using mathFunctions;

namespace Math
{
    class Program
    {
        static void Main(string[] args)
        {

            Functions mathFunctions = new Functions();
            var add = mathFunctions.Add(20, 10);
            Console.WriteLine("Add : " + add);

            var substract = mathFunctions.Substract(20, 10);
            Console.WriteLine("Substract : " + substract);

            var multiply = mathFunctions.Multiply(20, 10);
            Console.WriteLine("Multiply : " + multiply);

            var divide = mathFunctions.Divide(20, 10);
            Console.WriteLine("Divide : " + divide);

            Console.ReadLine();
        }
    }
}
