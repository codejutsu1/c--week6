class Program
{
    static void Main()
    {
        List<string> fruits = new List<string> {"apple", "banana", "cherry"};

        fruits.Add("date");

        fruits.Remove("banana");

        bool is_contain_cherry = fruits.Contains("cherry");

        Console.WriteLine("Elements in the list:");
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }
        
        Console.WriteLine("List contains 'cherry': " + is_contain_cherry);
    }
}