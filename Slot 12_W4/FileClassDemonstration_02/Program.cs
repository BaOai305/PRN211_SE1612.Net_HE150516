using System;
using System.IO;

namespace FileClassDemonstration_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"MyData.txt";
            // This text is added only once to the file.
            if (!File.Exists(path))
            {
                // Create a file to write to.
                string createText = "Hello and Welcome" + Environment.NewLine;
                File.WriteAllText(path, createText);
            }
            string appendText = "This is extra text" + Environment.NewLine;
            File.WriteAllText(path, appendText);
            // Open the file to read from.
            string readText = File.ReadAllText(path);
            Console.WriteLine(readText);
            Console.ReadLine();
        }
    }
}