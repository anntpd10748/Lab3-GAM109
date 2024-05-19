// See https://aka.ms/new-console-template for more information
using System;

public class Program
{
    static void Main(string[] args)
    {
        string path = "data.txt";
        using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
        {
            using (StreamWriter sw = new StreamWriter(fs))
            {
                sw.WriteLine("username: myUsername");
                sw.WriteLine("password: myPassword");
            }
            
        }
        using(var fs = new FileStream(path, FileMode.Open, FileAccess.Read))
        {
            using(StreamReader sr = new StreamReader(fs))
            {
                Console.WriteLine(sr.ReadToEnd());
            }
        }
    }
}
