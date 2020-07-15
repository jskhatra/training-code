using System;

namespace HelloCsharp
{
    class Program
    {
        static void Main(string[] args) // main function MUST be static
        {
            Console.Write("enter firstname: ");
            var first = Console.ReadLine(); //lazy
            Console.Write("enter lsatname: ");
            string last = Console.ReadLine(); //good

            Console.WriteLine(first + " " + last);
            Console.WriteLine("{0} {1}", first, last);
        

            Console.ReadLine();
            
        }
    }
}
