public class Reference
{
    private string _verse;
    private string _text;

    public Reference()
    {
    }

    public Reference(string verse, string text){
        _verse = verse;
        _text = text; 
    }

    public string GetVerse()
    {
        return _verse;
    }

    public void SetVerse (string verse)
    {
        _verse = verse;

    }
    public string GetText()
    {
        return _text;
    }

    public void SetText (string text)
    {
        _text = text;
    }
    
}