class Program 
{
    static void Main()
    {
        //Resizing a List Capacity
        List<int> numbers = new List<int>(100);

        for (int i = 0; i < 10; i++)
        {
            numbers.Add(i + 1);
        }

        Console.WriteLine($"Capacity of list: {numbers.Capacity}");
        Console.WriteLine($"Count of list: {numbers.Count}");
    }
}