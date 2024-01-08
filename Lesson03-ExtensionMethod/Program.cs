namespace Module1.Lesson03
{
    static public class Program
    {
        static void Main(string[] args)
        {
            string name = "Allan Levsen";
            Console.WriteLine(name.FormatName());
        }
    }

    static public class ExtensionMethods
    {
        static public string FormatName(this string s)
        {
            string[] sArray = s.Split(" ");

            return $"{sArray[1]}, {sArray[0]}";
        }
    }
}
