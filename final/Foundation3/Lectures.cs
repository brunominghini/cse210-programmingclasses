public class Lecture:Event{

    private string speaker;
    private int capacity;

    public void SetSpeaker(string _speaker){
        speaker = _speaker;
    }
    public string GetSpeaker(){
        return speaker;
    }

    public void SetCapacity(int _capacity){
        capacity = _capacity;
    }
    public int GetCapacity(){
        return capacity;
    }


    public string LectureDetails(){
        string lectureDetails;
        lectureDetails = "Speaker"+ GetSpeaker() + "Capacity:"+ GetCapacity();
        return lectureDetails;


    }
}