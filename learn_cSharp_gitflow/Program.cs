using System;
using System.Collections.Generic;
using System.Linq;

namespace learn_csharp_gitflow
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Hello Dunia Tipu-Tipu! menambahkan beberapa kata dari branch op0003");
            Console.WriteLine("Hello Gilang Agung Saputra hahahahha!");
            Console.WriteLine("Hello Agung!");
            Console.WriteLine("Hello Saputra!");

            int startNumber = 0;

            if(startNumber <= 0)
            {
                Console.WriteLine("print hasil dari if startNumber = 0");
                Console.WriteLine("Bombastic side eye (from op0003)");
            }

            Calculator calculatorOne = new Calculator();
            calculatorOne.Add(1, 2);
            calculatorOne.Substract(1, 2);
            calculatorOne.Multiply(1, 2);
            calculatorOne.Divide(1, 2);
        }
    }

    public class Calculator
    {
        public void Add(int numberOne, int numberTwo)
        {
            int total =  numberOne + numberTwo;
            Console.WriteLine("total add: " + total);
        }

        public void Substract(int numberOne, int numberTwo)
        {
            int total =  numberOne - numberTwo;
            Console.WriteLine("total substract: " + total);
        }

        public void Multiply(int numberOne, int numberTwo)
        {
            int total =  numberOne * numberTwo;
            Console.WriteLine("total multiply: " + total);
        }

        public void Divide(int numberOne, int numberTwo)
        {
            int total =  numberOne / numberTwo;
            Console.WriteLine("total divide: " + total);
        }
    }
}
