using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

class Program
{
    static void Main()
    {
        List<string> colorsList = new List<string> { "red", "green", "blue" };

        ReadOnlyCollection<string> readOnlyColors = new ReadOnlyCollection<string>(colorsList);

        try
        {
            readOnlyColors.Add("yellow"); // This line will throw an exception
        }
        catch (NotSupportedException ex)
        {
            Console.WriteLine("Error occurred: " + ex.Message);
        }   
    }
}