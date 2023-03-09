
public class Objective:Point
{
    private string _objective;
    private string _description;
    private string _historic;
    private double _pontuation;

    public Objective(string goal,
                    string time,
                    bool check,
                    double point,
                    double score,
                    string objective, 
                    string description, 
                    string historic, 
                    double pontuation):base(goal,time,check,point,score)
    {
        _objective = objective;
        _description = description;
        _historic = historic;
        _pontuation = pontuation;

    }

 
}