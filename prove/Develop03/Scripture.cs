/* public class Scripture
{
    private List<Word> _Words = List<Word>();
} */
/* public class Scripture
{

    private string _Reference {get;}
    private string _Text {get;}
    private bool[] _HiddenWords{get;}

    public Scripture(string reference, string text)
    {
        _Reference = reference;
        _Text = text;
        _HiddenWords = Enumerable.Repeat(false, text.Split('').Length).ToArray();
    }



} */

class Scripture
{
    private Reference reference;
    private List<Word> words;

    public bool AllWordsHidden
    {
        get { return words.TrueForAll(word => word.WordHidden()); }
    }

    public Scripture(string referenceText, string scriptureText)
    {
        reference = new Reference(referenceText);
        words = new List<Word>();

        string[] wordArray = scriptureText.Split(' ');
        for (int i = 0; i < wordArray.Length; i++)
        {
            words.Add(new Word(wordArray[i]));
        }
    }

    public void Display()
    {
        Console.WriteLine(reference.GetReference());
        foreach (Word word in words)
        {
            Console.Write(word.WordHidden() ? "____ " : $"{word.GetReference()} ");
        }
        Console.WriteLine();
    }

    public void HideRandomWord()
    {
        Random random = new Random();
        int index = random.Next(words.Count);

        while (words[index].WordHidden())
        {
            index = random.Next(words.Count);
        }

       /*  words[index].WordHidden() = true; */
    }
}