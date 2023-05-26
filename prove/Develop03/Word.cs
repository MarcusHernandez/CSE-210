/* public class Word
{
    private string _word;
    private Boolean _ishidden;
  /*   private string _hiddenword; 

    public Word(string word,Boolean isHidden=false)
    {
        _word = word;
    }


    public void HideWord()
    {
        _ishidden = true;
    }

    public void ShowWord()
    {
        _ishidden = false;
    }
    public string Display()

    {
        if (_ishidden ==true){
            return "__"; 
        }else{
            return $"{_word}";
        }
    }

} */

class Word
{
    private string _Text = "";
    private bool _Hidden;

    public Word(string wordText, bool Hidden=false)
    {
        _Text = wordText;
        _Hidden = Hidden;
    }

    public bool WordHidden()
    {
        _Hidden = true;
        return _Hidden;
    }

    public bool NotHidden()
    {
        _Hidden = false;
        return _Hidden;
    }

    internal object GetReference()
    {
        throw new NotImplementedException();
    }
}