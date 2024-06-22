class Program
{
    static void Main()
    {
        //Finding the maximum value in the list.
        List<int> numbers = new List<int>();

        Random rand = new Random();

        for (int i = 0; i < 10; i++)
        {
            numbers.Add(rand.Next(1, 100));
        }

        Console.WriteLine("Generated List: ");

        foreach (var num in numbers)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        int max = numbers[0];

        foreach (var num in numbers)
        {
            if(num > max) {
                max = num;
            }
        }

        Console.WriteLine("Maximum value in the list: " + max);
    }
}