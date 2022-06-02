using System;
using System.IO;

namespace StreamWriter_and_StreamReader_Demonstration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = null;
            string fileName = @"MyData.txt";
            Console.WriteLine("*****Demo StreamWriter and StreamReader*****\n");
            // Get a Streamwriter and write string data. 
            using StreamWriter writer = new StreamWriter(fileName);
            writer.WriteLine("Hello");
            writer.WriteLine("World");
            writer.WriteLine("!");
            for (int i = 1; i <= 10; i++)
            {
                writer.Write(i + " ");
            }
            // Insert a new line. 
            writer.Write(writer.NewLine);
            writer.Close();
            Console.WriteLine("File was created.");
            Console.WriteLine("********************");
            Console.WriteLine("Now read data from file.");
            using StreamReader sr = new StreamReader(fileName);
            while ((input = sr.ReadLine()) != null)
            {
                Console.WriteLine(input);
            }
            sr.Close();
            Console.ReadLine();


        }
    }
}
