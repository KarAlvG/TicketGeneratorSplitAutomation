using System;
using System.IO;

string folderPath = @"C:\FileGenerator";
string filePath = Path.Combine(folderPath, "output.txt");

try
{
    if (!Directory.Exists(folderPath))
    {
        Directory.CreateDirectory(folderPath);
        Console.WriteLine($"Folder created at: {folderPath}");
    }
    File.WriteAllText(filePath, "test");
    Console.WriteLine($"File generated succesfully at: {filePath}");
}
catch (Exception ex)
{
    Console.WriteLine("An error ocurred");
    Console.WriteLine(ex.Message);
}
