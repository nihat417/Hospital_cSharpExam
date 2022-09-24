namespace Hospital_cSharpExam.Time;
public class Worktime
{
    public Time _startsession { get; set; }
    public Time _endsession { get; set; }
    public bool _Isrezerved { get; set; }


    public void Isrezerved()
    {

    }

    public override string ToString()
    {
        return $"{_startsession} -- {_endsession} -- {_Isrezerved}";
    }
}
