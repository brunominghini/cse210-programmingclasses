

public class Entry{

    public DateTime Date;
    public string Name;

    public DateTime EntryDate()
    {
        Date = DateTime.Now;
        return Date;
    }

}