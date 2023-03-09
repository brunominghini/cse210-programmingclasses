public abstract class Point:Goal
{
    private double _points;
    private double _score;

    
    public Point(string goal,
                 string time,
                 bool check,
                 double point, 
                 double score):base(goal, time, check)
    {
        _points = point;
        _score = score;
    }

      public double getPoint()
    {
        return _points;
    }

    public void setScore(double score){
        _score = score;
    }

     public double getScore()
    {
        return _score;
    }

    public override double GetGoal(){

        return _points*_score;

    }


}