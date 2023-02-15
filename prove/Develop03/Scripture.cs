using System;
class Scripture 
{
private string _reference;
private string _scripture;

    /*Reference reference = new Reference();*/

    public List<Reference> Reference{get;set;}
    
    public Scripture()
    {
    }
    
    public Scripture(string reference, string scripture)
    {
        _reference = reference;
        _scripture = scripture;
    }
    

    public string GetReference()
    {
        return _reference;
    }

    public void SetReference (string reference)
    {
        _reference = reference;
    }

    public string GetScripture()
    {
        return _scripture;
    }
    public void SetScripture (string scripture)
    {
        _scripture = scripture;
    }

    public string GetAllScripture(){
            
        string AllScripture = $"{_scripture}" ;
        return AllScripture;
    }

}