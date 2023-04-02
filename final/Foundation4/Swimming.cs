public class Swimming:Activity
{
    private double laps;

    public void setLaps(double _laps){
        laps = _laps;
    }

    public double getLaps(){
        return laps;
    }

    public override double CalculateDistance()
    {
        double distance = laps * 50/1000;

        return distance;
    }

}