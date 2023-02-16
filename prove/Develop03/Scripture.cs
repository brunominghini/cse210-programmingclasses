using System.Linq;
public class Scripture
{

private string _scripture;

    /*Reference reference = new Reference();*/

    public List<Reference> _Reference{get;set;}
       
    public Scripture(List<Reference> reference, string scripture)
    {
        _Reference = reference;
        _scripture = scripture;
    }
    

    public Reference GetReference()
    {
        return _Reference[1];
    }

    public void SetScripture (string verseScripture, string textScripture)
    {
        _Reference.Add (new Reference(verseScripture, textScripture ));
    }

    public string GetScripture()
    {
        return _scripture;
    }
  
    public string GetAllScripture(){
            
        string AllScripture = $"{_scripture}" ;
        return AllScripture;
    }

}