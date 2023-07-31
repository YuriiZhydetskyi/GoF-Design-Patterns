using System.Collections;

namespace Iterator.Iterators;
class AuthorIterator : IEnumerator
{
    List<Book> bookList;
    int position = -1;

    public AuthorIterator(List<Book> list)
    {
        bookList = list.OrderBy(x => x.AuthorName).ToList();
    }

    public bool MoveNext()
    {
        position++;
        return (position < bookList.Count);
    }

    public void Reset()
    {
        position = -1;
    }

    object IEnumerator.Current
    {
        get
        {
            return Current;
        }
    }

    public string Current
    {
        get
        {
            try
            {
                return bookList[position].AuthorName;
            }
            catch (IndexOutOfRangeException)
            {
                throw new InvalidOperationException();
            }
        }
    }
}
