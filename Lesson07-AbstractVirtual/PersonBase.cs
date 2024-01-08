using System;
namespace Module2.Lesson07
{
    public abstract class PersonBase
    {
        public PersonBase()
        {
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }

        public virtual int Age()
        {
            return 40;
        }

        public abstract string PostalCode { get; }
        public abstract string FullName();




    }
}
