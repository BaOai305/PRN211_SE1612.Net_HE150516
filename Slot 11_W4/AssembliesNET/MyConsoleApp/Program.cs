using static System.Console;
using static MyLibrary.MyClass;

namespace MyConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 50, b = 25;
            int result;
            WriteLine("**********Demo Consuming Assemblies*****");
            //Invoke Add method
            result = a.Add(b);
            WriteLine($"{a}+{b}={result}");
            //Invoke Sub method
            result = a.Sub(b);
            WriteLine($"{a}-{b}={result}");
            ReadLine();
        }
    }
}
