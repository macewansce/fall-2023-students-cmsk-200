namespace Module2.Lesson06
{
    /*

    Classes can be declared as abstract by putting the keyword abstract before 
    the class definition. For example:

        public abstract class A
        {
            // Class members here.
        }

    An abstract class cannot be instantiated. The purpose of an abstract class is 
    to provide a common definition of a base class that multiple derived classes can 
    share. For example, a class library may define an abstract class that is used as 
    a parameter to many of its functions, and require programmers using that library 
    to provide their own implementation of the class by creating a derived class.

    Abstract classes may also define abstract methods. This is accomplished by adding 
    the keyword abstract before the return type of the method. For example:

        public abstract class A
        {
            public abstract void DoWork(int i);
        }

    Abstract methods have no implementation, so the method definition is followed by 
    a semicolon instead of a normal method block. Derived classes of the abstract 
    class must implement all abstract methods. When an abstract class inherits a 
    virtual method from a base class, the abstract class can override the virtual 
    method with an abstract method. For example:

        public class D
        {
            public virtual void DoWork(int i)
            {
                // Original implementation.
            }
        }

        public abstract class E : D
        {
            public abstract override void DoWork(int i);
        }

        public class F : E
        {
            public override void DoWork(int i)
            {
                // New implementation.
            }
        }

    */
    static public class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
