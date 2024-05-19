// See https://aka.ms/new-console-template for more information
using System;

public class Program
{
    static void Main(string[] args)
    {

        string username = "abc", password = "123", time = "2h30'";
        var sw = new StringWriter();
        sw.WriteLine("username: " + username);
        sw.WriteLine("password: " + password);
        var content = sw.ToString();   
        Console.WriteLine(content);

        var sr = new StringReader(content);
        sr.ReadLine();
    }
}
