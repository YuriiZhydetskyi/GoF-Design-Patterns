using System.Collections;

namespace Iterator.Iterators;
class ReleaseYearIterator : IEnumerator
{
    List<Book> bookList;
    int position = -1;

    public ReleaseYearIterator(List<Book> list)
    {
        bookList = list.OrderBy(x => x.ReleaseYear).ToList();
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

    public int Current
    {
        get
        {
            try
            {
                return bookList[position].ReleaseYear;
            }
            catch (IndexOutOfRangeException)
            {
                throw new InvalidOperationException();
            }
        }
    }
}
