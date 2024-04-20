using System;

class Book
{
    private Title title;
    private Author author;
    private Content content;

    public Book(string bookTitle, string authorName, string bookContent)
    {
        title = new Title(bookTitle);
        author = new Author(authorName);
        content = new Content(bookContent);
    }

    public void Show()
    {
        title.Show();
        author.Show();
        content.Show();
    }

    public string BookTitle
    {
        get { return title.TitleName; }
    }

    public string AuthorName
    {
        get { return author.AuthorName; }
        set { author.AuthorName = value; }
    }

    public string BookContent
    {
        get { return content.ContentText; }
        set { content.ContentText = value; }
    }
}

class Title
{
    private string titleName;

    public Title(string name)
    {
        titleName = name;
    }

    public void Show()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Title: " + titleName);
        Console.ResetColor();
    }

    public string TitleName
    {
        get { return titleName; }
    }
}

class Author
{
    private string authorName;

    public Author(string name)
    {
        authorName = name;
    }

    public void Show()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Author: " + authorName);
        Console.ResetColor();
    }

    public string AuthorName
    {
        get { return authorName; }
        set { authorName = value; }
    }
}

class Content
{
    private string contentText;

    public Content(string text)
    {
        contentText = text;
    }

    public void Show()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Content: " + contentText);
        Console.ResetColor();
    }

    public string ContentText
    {
        get { return contentText; }
        set { contentText = value; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Book myBook = new Book("C# Programming", "John Doe", "This is the content of the book.");
        myBook.Show();

        // Modify author name and book content
        myBook.AuthorName = "Jane Smith";
        myBook.BookContent = "This is the updated content of the book.";
        myBook.Show();
    }
}
