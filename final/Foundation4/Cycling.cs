public class Cycling:Activity
{

    private string dificulty;
   

    public void setDificulty(string _dificulty){
        dificulty = _dificulty;
    }

    public string getDificulty(){
        return dificulty;
    }

    public override double CalculateSpeed()
    {
        double duration = getDuration();
        double distance =  getDistance();
        return (distance / duration) *60;
    }

    public override double CalculatePace(){

        double duration = getDuration();
        double distance =  getDistance();
        double speed = (duration / distance)*60;
        double pace = speed/60;
        return pace;
    }

}