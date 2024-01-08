namespace Module1.Lesson04
{
    /*
    All types and type members have an accessibility level. 
    The accessibility level controls whether they can be used from 
    other code in your assembly or other assemblies. 
    
    An assembly is a .dll or .exe created by compiling one or 
    more .cs files in a single compilation. Use the following 
    access modifiers to specify the accessibility of a type or 
    member when you declare it:


    public:     The type or member can be accessed by any other code in 
                the same assembly or another assembly that references it. 
                The accessibility level of public members of a type is 
                controlled by the accessibility level of the type itself.

    private:    The type or member can be accessed only by code in the 
                same class or struct.

    protected:  The type or member can be accessed only by code in the 
                same class, or in a class that is derived from that class.

    internal:   The type or member can be accessed by any code in the 
                same assembly, but not from another assembly. In other words, 
                internal types or members can be accessed from code that is part 
                of the same compilation.
    */

    static public class Program
    {
        static void Main(string[] args)
        {
        }
    }

}

