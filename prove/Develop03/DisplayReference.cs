// The DisplayRefernce Class, keeps track of the book, chapter, and verse information
// of the scripture reference. Has methods to get the reference string in a formatted manner.

public class DisplayReference
{
    private string _book;
    private int _chapter; 
    private int _verseStart;
    private int _verseEnd;
    private string _theVerse;

    public DisplayReference (string book, int chap, int vrs_s)
    {

        _book = book;
        _chapter = chap;
        _verseStart = vrs_s;
    }

    public DisplayReference (string book, int chap, int vrs_s, int vrs_e)
    {
        _book = book;
        _chapter = chap;
        _verseStart = vrs_s;
        _verseEnd = vrs_e;
    }

    public string GetFormattedReference()
    {
        if (_verseEnd == 0)
        {
            return $"{_book} {_chapter}:{_verseStart}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verseStart}-{_verseEnd}";
        }
        
    }

    public void SetVerse()
    {
        _theVerse  = Console.ReadLine();
    }

    public string GetTheVerse()
    {
        return _theVerse;
    }
    public string GetBook()
    {
        return _book;
    }

    public int GetChap() {
        return _chapter;
    }
    public int GetVrs_S()
    {
        return _verseStart;
    }
    public int GetVrs_E()
    {
        return _verseEnd;
    }
}