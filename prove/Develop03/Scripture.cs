using System;
using System.Collections.Generic;
// The Scripture Class, keep track of the reference and text of the scripture.
// Has methods to hide the words in the scripture text, get the rendered text
// and reference from the DisplayReference class, and also checks if all words are hidden.

public class Scripture
{   
    private DisplayReference _theRef;
    private ScriptureWord theText;
    private List<string> _listVerse = new List<string>();

    private List<string> _hiddenWords = new List<string>();
    private string[] _text;

    public Scripture(DisplayReference reference)
    {
        _theRef = reference;
        _text = _theRef.GetTheVerse().Split(" ");
        foreach (var word in _text)
        {
            theText = new ScriptureWord(word);
            _listVerse.Add(theText.GetRenderedText());
        }
    }

    public void HideWord (int number)
    {
        Random random = new Random();
        
        for (int i = 0; i < number; i++)
        {
            int randNum = random.Next(_listVerse.Count());
            string removeWord = _listVerse[randNum];
            
            if (removeWord != "________")
            {
                _hiddenWords.Add(removeWord);
            }
            if(removeWord == "________")
            {
                randNum = random.Next(_listVerse.Count());
                
            }
            
            _listVerse.RemoveAt(randNum);
            theText.Hide();
            _listVerse.Insert(randNum, theText.GetRenderedText());
        }

    }

    public bool IsAllWordHidden()
    {
        bool isIt = false;
        bool result = _listVerse.All(word => word == "________");
        if(result)
        {
            isIt = true;
        }
        return isIt;
    }
    
    public void DisplayText()
    {
        string theRef = _theRef.GetFormattedReference();
        Console.WriteLine($"\n{theRef}\n{string.Join(" ", _listVerse)}\n");
    }

}