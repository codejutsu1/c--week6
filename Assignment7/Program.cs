class Program
{
    static void Main()
    {
        // Create and Manipulate an Array.
        int[] numbers = { 10, 20, 30, 40, 50 };

        Console.WriteLine("Length of the array: " + numbers.Length);

        numbers[2] = 35;

        Console.WriteLine("Elements in the array:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}