class Program 
{
    static void Main()
    {
        // List of Custom Objects.
        List<Book> books = new List<Book>();

        books.Add(new Book("Nigeria Nawa oh", "E.B Things"));
        books.Add(new Book("My First Programming Language", "D.Z Juio"));
        books.Add(new Book("World, good or better?", "Annonymous"));
        books.Add(new Book("End of Beginning?", "I.C Shege"));

        Console.WriteLine("List of Books:");
        foreach (var book in books)
        {
            Console.WriteLine($"Title: {book.Title}, Author: {book.Author}");
        }
    }
}