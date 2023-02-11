// The ScriptureWord class keeps track of a single word in the scripture text.
// Has methods to hide or show the word, check if it is hidden, and get the rendered
// text of the word.

public class ScriptureWord
{
    private string _theWord;
    private bool _isHidden;

    public ScriptureWord(string text)
    {
        _theWord = text;
        _isHidden = false;
    }

    public string GetRenderedText()
    {
        if(_isHidden == true)
        {
            _theWord = "________";
        }
        return _theWord;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }
}