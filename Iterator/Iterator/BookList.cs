using System.Collections;

namespace Iterator;

class BookList : IEnumerable
{
    public List<Book> books = new List<Book>();

    public void AddBook(Book book)
    {
        books.Add(book);
    }

    public IEnumerator GetEnumerator()
    {
        return books.GetEnumerator();
    }
}