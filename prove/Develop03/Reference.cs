/* public class Reference
{

    private string _book = "";
    private int _chapter;
    private int _firstVerse;
    private int _lastVerse;

public Reference(string book, int chapter, int firstVerse, int Lastverse=0)
{
    _book = book;
    _chapter = chapter;
    _firstVerse = firstVerse;
}

public int GetLastVerse(int lastVerse)
{
    _lastVerse = lastVerse;
    return lastVerse;
}
    public string Display()
    {
        return $"{_book} {_chapter}:{_firstVerse}-{_lastVerse}";
    }

} */

class Reference
{
    private string _Text= "";

    public Reference(string referenceText)
    {
        _Text = referenceText;
    }

    public string GetReference()
    {
        _Text = "";
        return _Text;
    }
}