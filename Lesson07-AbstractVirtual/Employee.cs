using System;
namespace Module2.Lesson07
{
    public class Employee : PersonBase
    {
        public Employee()
        {
        }

        public override string PostalCode => "sdfsdfsf";

        public override string FullName()
        {
            return $"{FirstName} {LastName}";
        }

        public override int Age()
        {
            int age = base.Age();
            return age + 2;
        }



    }
}
