public class Activity
{
    private string date;
    private double duration;
    private double distance;
    private double speed;

    public void setDate(string _date){
        date = _date;
    }

    public string getDate(){
        return date;
    }
    public void setDuration(double _duration){
        duration = _duration;
    }

    public double getDuration(){
        return duration;
    }

    public void setDistance(double _distance){
        distance = _distance;

    }

    public double getDistance(){
        return distance;
    }
    public void setSpeed(int _speed){
        speed = _speed;
    }

    public double getSpeed(){
        return speed;
    }

    public Activity RegisterActivity(string date, double duration){
        Activity activity = new Activity();
        activity.setDate(date);
        activity.setDuration(duration);
        return activity;
    }

    public virtual double CalculateDistance(){
        double result=0;
        return result;
    }

    public virtual double CalculateSpeed(){
        double result=0;
        return result;
    }

    public virtual double CalculatePace(){
        double result=0;
        return result;
    }

    
}