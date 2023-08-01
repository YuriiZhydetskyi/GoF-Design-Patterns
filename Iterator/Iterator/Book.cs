namespace Iterator;

class Book
{
    public string AuthorName { get; set; }
    public string Title { get; set; }
    public int ReleaseYear { get; set; }

    public Book(string author, string title, int releaseYear)
    {
        AuthorName = author;
        Title = title;
        ReleaseYear = releaseYear;
    }
}