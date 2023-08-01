using Iterator;
using Iterator.Iterators;

class Program
{
    static void Main(string[] args)
    {
        BookList bookList = new BookList();

        bookList.AddBook(new Book("Antoine de Saint-Exupéry", "The Little Prince", 1943));
        bookList.AddBook(new Book("Mark Twain", "Tom Sawyer", 1876));
        bookList.AddBook(new Book("Mark Twain", "Huckleberry Finn", 1884));

        AuthorIterator authorIterator = new AuthorIterator(bookList.books);
        TitleIterator titleIterator = new TitleIterator(bookList.books);
        ReleaseYearIterator releaseYearIterator = new ReleaseYearIterator(bookList.books);

        Console.WriteLine("Authors:");
        while (authorIterator.MoveNext())
        {
            Console.WriteLine(authorIterator.Current);
        }

        Console.WriteLine("\nTitles:");
        while (titleIterator.MoveNext())
        {
            Console.WriteLine(titleIterator.Current);
        }

        Console.WriteLine("\nRelease Years:");
        while (releaseYearIterator.MoveNext())
        {
            Console.WriteLine(releaseYearIterator.Current);
        }
    }
}