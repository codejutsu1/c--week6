class Program 
{
    static void Main()
    {
        //Merging Two Arrays
        int[] array1 = {1,2,3};
        int[] array2 = {4,5,6};

        int length = array1.Length + array2.Length;

        int[] mergedArray = new int[length];

        Array.Copy(array1, mergedArray, array1.Length);

        Array.Copy(array2, 0, mergedArray, array1.Length, array2.Length);

        Console.WriteLine("Merged Array:");

        foreach (var num in mergedArray)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}