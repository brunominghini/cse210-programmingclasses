using System;

public class Video: Comment

{

    public string _title;
    public string _author;
    public int  _length;

    //public  Video (string title, string author, int length, string name, string comment):base (name, comment)
    public Video  (string title,
                    string author,
                    int length,
                    string name,
                    string comment) : base(name, comment)
    {
        _title = title;
        _author = author;
        _length = length;
        
    }

    



    
    
}