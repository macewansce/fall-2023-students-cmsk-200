using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Person
    {
        public int PersonId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {

                 
            var listOfNumbers = new List<int>()
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            };


            // Query Syntax of LINQ
            //
            var query = from n in listOfNumbers
                        where n > 5
                        select n;

            // projection
            //
            var query11 = from n in listOfNumbers
                          where n > 5
                          select new Person
                          {
                              PersonId = n,
                              Name = $"Person {n}",
                              Address = "sadasda"
                          };



            // You can mix Extension method operators with query syntax
            var query10 = (from n in listOfNumbers
                           where n > 5
                           select n).Skip(10).Take(10);

            // Extension Method Syntax of LINQ
            //
            var query2 = listOfNumbers.Where(x => x > 5).Select(x => x);

            // projection
            //
            var query20 = listOfNumbers
                            .Where(b => b > 5)
                            .Select(
                                n => new Person()
                                {
                                    PersonId = n,
                                    Name = $"Person {n}",
                                    Address = "sadasda"
                                });


            // This DOES work for general LINQ (c#) code
            // but would fail when used in a Data Context (MS SQL Server) 
            var query30 = listOfNumbers
                            .Where(b =>
                            {
                                var total = 50 * 50;
                                if (total > 2)
                                    return true;
                                return false;
                            })
                            .Select(x => x);


            var query3 = listOfNumbers.Skip(2).Take(6).Where(x => x > 17).Select(x => x);
            int five = listOfNumbers.SingleOrDefault(x => x == 50);
            var numbers = listOfNumbers.TakeWhile(x => x > 5).Take(2).Select(x => x);
            var numbers2 = listOfNumbers.Any(x => x > 5);



            Console.WriteLine("Hello World!");
        }



 
        private static void NewMethod()
        {
            var person = new Person
            {
                Name = "Allan",
                Address = "123 anderson"
            };

            var people = new List<Person>()
            {
                new Person() { Name="12312", Address="!2312"},
                new Person() { Name="12312", Address="!2312"},
                new Person() { Name="12312", Address="!2312"},
                new Person() { Name="12312", Address="!2312"},
                new Person() { Name="12312", Address="!2312"},
                new Person() { Name="12312", Address="!2312"},
                new Person() { Name="12312", Address="!2312"},
                new Person() { Name="12312", Address="!2312"},
            };
        }
    }
}
