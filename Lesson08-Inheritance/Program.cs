namespace Module2.Lesson08
{
    /*

    Inheritance enables you to create new classes that reuse, extend, and modify 
    the behavior defined in other classes. The class whose members are inherited 
    is called the base class, and the class that inherits those members is called 
    the derived class. 
    
    A derived class can have only one direct base class. However, 
    inheritance is transitive. If ClassC is derived from ClassB, and ClassB is derived 
    from ClassA, ClassC inherits the members declared in ClassB and ClassA.

    Note: Structs do not support inheritance, but they can implement interfaces.

    Conceptually, a derived class is a specialization of the base class. For example, 
    if you have a base class Animal, you might have one derived class that is named 
    Mammal and another derived class that is named Reptile. A Mammal is an Animal, 
    and a Reptile is an Animal, but each derived class represents different 
    specializations of the base class.

    Interface declarations may define a default implementation for its members. 
    These implementations are inherited by derived interfaces, and by classes that 
    implement those interfaces.

    When you define a class to derive from another class, the derived class implicitly 
    gains all the members of the base class, except for its constructors and finalizers.
    
    The derived class reuses the code in the base class without having to reimplement 
    it. You can add more members in the derived class. The derived class extends the 
    functionality of the base class.

    */

    // base class
    public class Animal
    {
        public string name;

        public void display()
        {
            Console.WriteLine("I am an animal");
        }
    }

    // derived class of Animal 
    public class Dog : Animal
    {
        public void getName()
        {
            Console.WriteLine("My name is " + name);
        }
    }

    static public class Program
    {
        static void Main(string[] args)
        {
            // object of derived class
            Dog labrador = new Dog();

            // access field and method of base class
            labrador.name = "Rohu";
            labrador.display();

            // access method from own class
            labrador.getName();

            Console.ReadLine();
        }
    }
}
