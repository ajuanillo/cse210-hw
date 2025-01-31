public class Scripture
{
    private Reference _reference;
    private List<Word> _words=new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference=reference;
        
        string[] texts=text.Split(" ");
        for(int i=0; i<texts.Count();i++)
        {
            _words.Add(new Word(texts[i]));
        }
    }
    public void HideRandomWords(int numberToHide)
    {
        for(int i=1;i<=numberToHide;i++)
        {
            Random rnd = new Random();
            _words[rnd.Next(_words.Count)].Hide();
        }
    }
    public string GetDisplay()
    {
        List<string> text=new List<string>();
        foreach(Word w in _words)
        {
            text.Add(w.GetDisplayText());
        }
        string allText=String.Join(" ",text);
        return _reference.GetDisplayText()+" "+allText;
    }
    public bool IsCompleteHidden()
    {
        foreach(Word w in _words)
        {
            if(w.IsHidden()==false)
            {
                return false;
            }
        }
        return true;
    }
}