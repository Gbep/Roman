using System;
using System.IO;


    class TestClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("File does not exist.");
            Console.WriteLine("File does not exist.");
            Console.WriteLine("File has been written.");
            Console.ReadKey();
        }
    }

    public interface IRead
    {
        string Read(string filePath);
    }

    public interface IWrite
    {
        void Write(string filePath, string content);
    }


    public class FileService : IRead, IWrite
    {
        public string Read(string filePath)
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("File does not exist.");
                return null!;
            }
            string text = File.ReadAllText(filePath);
            Console.WriteLine(text);
            return text;
        }

        public void Write(string filePath, string content)
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("File does not exist.");
                return;
            }
            File.WriteAllText(filePath, content);
            Console.WriteLine("File has been written.");
        }
    }


