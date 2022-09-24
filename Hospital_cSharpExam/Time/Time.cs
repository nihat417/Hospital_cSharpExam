namespace Hospital_cSharpExam.Time;

public class Time
{
    public int _hour { get; set; }
    public int _minute { get; set; }

    //public Time(TimeOnly hour, TimeOnly minute)
    //{
    //    _hour = hour;
    //    _minute = minute;
    //}

    public override string ToString()
    {
        return $"{_hour}:{_minute}";
    }
}
