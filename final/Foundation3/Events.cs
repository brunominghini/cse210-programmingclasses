public class Event{
    private string typeEvent;
    private string title;
    private string description;
    private string dateTime;
    private string address;

     public void SetType(string _typeEvent){
        typeEvent = _typeEvent;
    }
    public string GetTypeEvent(){
        return typeEvent;
    }
     public void SetTitle(string _title){
        title = _title;
    }
    public string GetTitle(){
        return title;
    }

    public void SetDescription(string _description){
        description = _description;
    }
    public string GetDescription(){
        return description;
    }

    public void SetDateTime(string _dateTime){
        dateTime = _dateTime;
    }
    public string GetDateTime(){
        return dateTime;
    }
    
    public void SetAddress(string _address){
        address = _address;
    }
    public string GetAddress(){
        return address;
    }

    public void CreatEvent(string typeEvent, string _title, string _description, string _dateTime, string _address){
        
        SetTitle(_title);
        SetDescription(_description);
        SetDateTime(_dateTime);
        SetAddress(_address);
      
    }

    public string EventStandardDetails(){
        string title = GetTitle();
        string description = GetDescription();
        string dateTime = GetDateTime();
        string address = GetAddress();
        string details = ($"Title of event:{title}. \n Description: {description} \n Address:{address} \n Date:{dateTime}");
        return details;
    }

    public string EventFullDetails(){
        string title = GetTitle();
        string description = GetDescription();
        string dateTime = GetDateTime();
        string address = GetAddress(); 
        string details = ($"Title of event:{title}. \n Description: {description} \n Address:{address} \n Date:{dateTime}");
        return details;
    }

    public string ShortDescription(){
        string title = GetTitle();     
        string dateTime = GetDateTime();
        string details = ($"Title of event:{title}.\n Date:{dateTime}");
        return details;
    }
}