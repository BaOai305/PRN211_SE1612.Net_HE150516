using System;
using System.IO;

namespace FileInfoClassDemonstration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string FileName = @"MyFile.txt";
            Console.WriteLine("******Demo FileInfo Class*******\n");
            //Create a Text file
            File.WriteAllText(FileName, "Hello World.");
            //Read file content
            Console.WriteLine("Read file: ");
            string content = File.ReadAllText(FileName);
            Console.WriteLine(content);
            Console.WriteLine("File infomation:");
            //Get file information
            FileInfo testFile = new FileInfo(FileName);
            Console.WriteLine($"Name: {testFile.Name}");
            // Creation time.
            Console.WriteLine($"Creation time: {testFile.CreationTime}");
            // Last Write Time.
            Console.WriteLine($"Last Write Time: {testFile.LastWriteTime}");
            // Name of parent Directory.
            Console.WriteLine($"Directory Name: {testFile.DirectoryName}");
            Console.ReadLine();
        }
    }
}
