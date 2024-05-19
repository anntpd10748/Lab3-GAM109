// See https://aka.ms/new-console-template for more information
using System;
using System.IO;

public class Program
{
    static void create(string path)
    {
        Directory.CreateDirectory(path);

        string filePath = Path.Combine(path, "data.txt");

        StreamWriter streamWriter = new StreamWriter(filePath);
        streamWriter.WriteLine("mssv:abc12345");
        streamWriter.WriteLine("ho va ten: tran van a");
        streamWriter.Dispose();
    }
    static void copy(string soucrePath, string destinationPath)
    {
        if(Directory.Exists(destinationPath)==false)
        {
            Directory.CreateDirectory (destinationPath);

            string[] filelist = Directory.GetFiles(soucrePath);

            foreach (string file in filelist)
            {
                var fileInfo = new FileInfo(file);
                fileInfo.CopyTo(Path.Combine(destinationPath, fileInfo.Name), true);
            }
        }
    }
    static void Main(string[] args)
    {
        String path1 = "data";
        string path2 = "data2";
        create(path1);
        copy(path1, path2);
    }
}
