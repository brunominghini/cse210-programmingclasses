

//Keeps track of the company, job title, start year, and end year.
public class Job{


public string _jobTitle="";
public string _company="";
public int _startYear;
public int _endYear;

    //Displays the job information in the format 
    //"Job Title (Company) StartYear-EndYear"
    public void DisplayInformationJob()
    {
    Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}.");
    }

}