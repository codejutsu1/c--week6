class Program 
{
    static void Main()
    {
        //Sorting and Reversing an array
        int[] numbers = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5 };

        Array.Sort(numbers);

        Array.Reverse(numbers);

        Console.WriteLine("Sorted and Reversed Array:");
        
        foreach (var num in numbers)
        {
            Console.Write(num + " ");
        }

        Console.WriteLine();
    }
}