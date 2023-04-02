public class Running: Activity
 {
    private string weather ;
    private double speed;

    public void setWeather(string _weather){
        weather = _weather;
    }

    public string getWeather(){
        return weather;
    }
public override double CalculateSpeed()
    {
        double duration = getDuration();
        double distance =  getDistance();
        return (duration / distance)*60;
    }
public override double CalculatePace(){

        double duration = getDuration();
        double distance =  getDistance();
        double speed = (duration / distance)*60;
        double pace = speed/60;
        return pace;
    }



}