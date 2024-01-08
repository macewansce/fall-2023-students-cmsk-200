using System;

namespace Module01.Lesson02
{

    /*
     
        Sealed Classes

        Classes can be declared as sealed by putting the keyword sealed before the 
        class definition. For example:

            public sealed class D
            {
                // Class members here.
            }

        A sealed class cannot be used as a base class. For this reason, it cannot also 
        be an abstract class. Sealed classes prevent derivation. Because they can never 
        be used as a base class, some run-time optimizations can make calling sealed class 
        members slightly faster.

        A method, indexer, property, or event, on a derived class that is overriding a 
        virtual member of the base class can declare that member as sealed. This negates the 
        virtual aspect of the member for any further derived class. This is accomplished by 
        putting the sealed keyword before the override keyword in the class member declaration. 
        For example:

            public class D : C
            {
                public sealed override void DoWork() { }
            }

        ---------------------------------------------------------------------------------------

        Static Classes

        A static class is basically the same as a non-static class, but there is one 
        difference: a static class cannot be instantiated. In other words, you cannot 
        use the new operator to create a variable of the class type. Because there is no 
        instance variable, you access the members of a static class by using the class name 
        itself. For example, if you have a static class that is named UtilityClass that 
        has a public static method named MethodA, you call the method as shown in the 
        following example:

            UtilityClass.MethodA(); 

        A static class can be used as a convenient container for sets of methods that 
        just operate on input parameters and do not have to get or set any internal instance 
        fields. For example, in the .NET Class Library, the static System.Math class contains 
        methods that perform mathematical operations, without any requirement to store or 
        retrieve data that is unique to a particular instance of the Math class. That is, 
        you apply the members of the class by specifying the class name and the method name, 
        as shown in the following example.

            double dub = -3.14;  
            Console.WriteLine(Math.Abs(dub));  
            Console.WriteLine(Math.Floor(dub));  
            Console.WriteLine(Math.Round(Math.Abs(dub))); 

        ---------------------------------------------------------------------------------------

        Partial Classes

        It is possible to split the definition of a class, a struct, an interface
        or a method over two or more source files.Each source file contains a 
        section of the type or method definition, and all parts are combined when 
        the application is compiled.

        There are several situations when splitting a class definition is desirable:

        -   When working on large projects, spreading a class over separate files 
            enables multiple programmers to work on it at the same time.
        -   When working with automatically generated source, code can be added to the 
            class without having to recreate the source file.Visual Studio uses this 
            approach when it creates Windows Forms, Web service wrapper code, and so on.
    
            You can create code that uses these classes without having to modify the file 
            created by Visual Studio.

        -   When using source generators to generate additional functionality in a class.

    */

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
