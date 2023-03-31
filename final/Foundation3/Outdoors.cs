public class Outdoor:Event{

    private string weather;
    

    public void SetWeather(string _weather){
        weather = _weather;
    }
    public string GetWeather(){
        return weather;
    }

    public string WeatherStatement(){
         weather = "The weather" + weather;
         return weather;
    }
}