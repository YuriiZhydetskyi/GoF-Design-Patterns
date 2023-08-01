using System.Collections;

namespace Iterator.Iterators;
class TitleIterator : IEnumerator
{
    List<Book> bookList;
    int position = -1;

    public TitleIterator(List<Book> list)
    {
        bookList = list.OrderBy(x => x.Title).ToList();
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
                return bookList[position].Title;
            }
            catch (IndexOutOfRangeException)
            {
                throw new InvalidOperationException();
            }
        }
    }
}
