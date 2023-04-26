public class Book
{

    private string _author;
    private string _name;
    private int _timesread=0;
    private bool _available=true;


public Book(string name, string author)
{
    _name = name;
    _author = author;
}
public void display()
{
Console.WriteLine($"{_name} by {_author}");
if(!_available)
{
    Console.WriteLine("[Checked Out]");
}
}

public bool IsAvailable()
{
    return _available;
}

public void Checkout()
{
    _available = false;
    _timesread +=1;
}

public void Checkin()
{
    _available = true;
}

public bool hasAuthor(string author)
{
    return _author.Contains(author);
}

}