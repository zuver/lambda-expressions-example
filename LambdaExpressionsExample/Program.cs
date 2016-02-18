using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionsExample
{
    class Program
    {
        // Declare delegate named Square that returns an int and takes an int as an argument
        delegate int Square(int n);

        // SquareNumber satisfies the requirements of the Square delegate (returns an int and takes an int an argument)
        static int SquareInteger(int someInteger)
        {
            return someInteger * someInteger;
        }

        static void Main(string[] args)
        {
            // Use lambda expression to define the Square delegate
            Square squareLambdaExpression = (x) => { return x * x; };
            Console.WriteLine("squareLambdaExpression(5) returns " + squareLambdaExpression(5));

            // Use anonymous method to define the Square delegate
            Square squareAnonymousMethod = delegate(int n) { return n * n; };
            Console.WriteLine("squareAnonymousMethod(5) returns " + squareAnonymousMethod(5));

            // Use static method to define the Square delegate
            Square squareStaticMethod = new Square(SquareInteger);
            Console.WriteLine("squareStaticMethod(5) returns " + squareStaticMethod(5));
        }
    }
}
