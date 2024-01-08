using System;
using System.Collections.Generic;

namespace Module03.Lesson10
{


    public interface IMessageLogger
    {
        public string Name { get; set; }

        void LogMessage(string message);
    }


    public class SqlDatabaseLogger : IMessageLogger
    {
        public string Name { get; set; }

        public void LogMessage(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine("Logged message to sql database");
        }

    }

    public class FileDatabaseLogger : IMessageLogger
    {
        public string Name { get; set; }
        public void LogMessage(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine("Logged message to log file");
        }
    }

    public class SMSMessageLogger : IMessageLogger
    {
        public string Name { get; set; }
        public void LogMessage(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine("Logged message to text mssage");
        }
    }



    class Program
    {

        static void Main(string[] args)
        {

            List<IMessageLogger> msgLoggers = new List<IMessageLogger>();
            msgLoggers.Add(new SqlDatabaseLogger());
            msgLoggers.Add(new SMSMessageLogger());


            foreach (IMessageLogger msgLogger in msgLoggers)
                msgLogger.LogMessage("Error occured...");

        }
    }
}
