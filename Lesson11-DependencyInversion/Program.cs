using System;

namespace Module03.Lesson11
{

    public interface IPerson
    {
        int PersonId { get; set; }
        int Status { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string EmailAddress { get; set; }
        string PhoneNumber { get; set; }
    }

    public class Person : IPerson
    {
        public int PersonId { get; set; }
        public int Status { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
    }

    public interface INotifyService
    {
        void Notify();
    }

    public class EmailService : INotifyService
    {
        IPerson _person = null;

        public EmailService(IPerson person)
        {
            _person = person;
        }

        public void Notify()
        {
            // send an email to _person
            //
            Console.WriteLine($"{_person.FirstName} was sent an email at {_person.EmailAddress}");
        }
    }

    public class SMSService : INotifyService
    {
        IPerson _person = null;

        public SMSService(IPerson person)
        {
            _person = person;
        }

        public void Notify()
        {
            // send an text message to person
            //
            Console.WriteLine($"{_person.FirstName} was sent a text to {_person.PhoneNumber}");
        }
    }


    public class OrderService
    {
        IPerson _person = null;
        INotifyService _notifyService;

        public OrderService(IPerson person, INotifyService notifyService)
        {
            _person = person;
            _notifyService = notifyService;
        }

        public void ProcessOrder()
        {
            //
            // process the order for this person here
            //
            Console.WriteLine($"Processing {_person.FirstName}'s order...");

        }

        public void Notify()
        {
            _notifyService.Notify();
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            IPerson person = GetPerson();
            INotifyService notifyService = new SMSService(person);

            OrderService orderService = new OrderService(person, notifyService);
            orderService.ProcessOrder();
            orderService.Notify();

            Console.ReadKey();
        }

        static Person GetPerson()
        {
            return new Person()
            {
                PersonId = 1,
                Status = 100,
                FirstName = "Allan",
                LastName = "Levsen",
                EmailAddress = "alevsen@nait.ca",
                PhoneNumber = "(780) 999-9876"
            };
        }

    }
}




