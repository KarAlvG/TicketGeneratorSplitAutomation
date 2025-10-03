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

    Random random = new Random();

    int length = random.Next(6, 9);

    char[] ticket = new char[length];

    ticket[0] = (char)('0' + random.Next(1, 4));

    if (random.Next(2) == 0)
    {
        ticket[1] = (char)('A' + random.Next(6));
    }
    else
    {
        ticket[1] = (char)('0' + random.Next(10));
    }

    for (int i = 2; i < length; i++)
    {
        ticket[i] = (char)('0' + random.Next(10));
    }

    string ticketString = new string(ticket);


    File.WriteAllText(filePath, ticketString);
    Console.WriteLine($"Ticket generated succesfully at: {ticketString}");
    Console.WriteLine($"Saved at {filePath}");
    
}
catch (Exception ex)
{
    Console.WriteLine("An error ocurred");
    Console.WriteLine(ex.Message);
}
