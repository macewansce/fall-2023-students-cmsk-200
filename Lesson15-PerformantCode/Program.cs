using System;
using System.Threading.Tasks;

namespace Module04.Lesson15
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("1. Start");
            PerformAsyncDatabase();
            Console.WriteLine("3. After database call");

            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }


        static void PerformAsyncDatabase()
        {
           Task.Run(async () =>
           {
               await LongFunction();
               Console.WriteLine("2. Finished long function");
           });
        }


        static async Task LongFunction()
        {
            await Task.Delay(5000);
        }

    }
}
