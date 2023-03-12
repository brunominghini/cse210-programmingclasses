using System;
public class Goal
{
    private string _goal{get;set;}
    private string _time{get;set;}
    private bool _check {get;set;}
 
    public Goal (string goal,
                 string time,
                 bool check)
    {
        _goal = goal;
        _time = time;
        _check = check;
        
    }
    public virtual double GetGoal(){
        return 0;
    }

}