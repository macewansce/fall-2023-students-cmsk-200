using System;
using System.Collections.Generic;
using System.Linq;

namespace Module04.Lesson13and14
{
    class Program
    {

        static bool ValidNumbers(int n)
        {
            if (n < 10)
                return true;

            return false;
        }

        static int GetNumber(int n)
        {
            return n;
        }

        static void Main(string[] args)
        {

            var numbers = Enumerable.Range(0, 100).ToList();



            var query = numbers
                       .Where(ValidNumbers)
                       .Select(GetNumber);

            var query1 = numbers.Where(x => x<10).Select(x => x);

            var query11 = numbers.Where(x => x > 10 && x < 25).Select(x => x);

            var query2 = (from number in numbers
                             where number < 10
                             select new
                             {
                                 Name = "$Number{number}",
                                 Number = number
                             }
                         ).ToList();

            foreach( var number in query2)
            {

                Console.WriteLine($"{number.Name} -> {number.Number}");
            }


            




        }



        static void DisplayHello(string message)
        {
            Console.WriteLine($"Hello message: {message}");
        }

        static void DisplayHello2(string message, string secondMessage)
        {
            Console.WriteLine($"Hello message: {message} - {secondMessage}");
        }

        static double CalculateTaxesPercentage(int counter, int years)
        {
            return 24d;
        }

        static int AddTwoNumbers(int number1, int number2)
        {
            return number1 + number2;
        }

        private static void ActionFuncExamples()
        {
            var sayHello = new Action<string>(DisplayHello);
            sayHello("Allan");

            var sayHello2 = new Action<string, string>(DisplayHello2);
            sayHello2("Allan", "Levsen");


            Func<int, int, double> GetTaxPercentage = CalculateTaxesPercentage;
            double d = GetTaxPercentage(10, 10);


            Func<int, int, int> sumTwoNumbers = (x, y) => x + y;
            int total = sumTwoNumbers(10, 15);

            Func<int, int, int> addTwoNumbers = AddTwoNumbers;
            int t = addTwoNumbers(25, 14);

            Console.WriteLine(t);
        }
    }
}
