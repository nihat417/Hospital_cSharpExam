namespace Hospital_cSharpExam.Time;
public class Worktime
{
    public Time _startsession { get; set; }
    public Time _endsession { get; set; }
    public bool _Isrezerved { get; set; }



    public override string ToString()
    {
        return $"{_startsession} -- {_endsession} -- {_Isrezerved}";
    }
}

public class Workdate
{
    public DateTime Year { get; set; }
   
    public Worktime worktim { get; set; }

    public Workdate(DateTime Year, Worktime worktim)
    {
        this.Year = Year;
        
        this.worktim = worktim;
    }

    public override string ToString()
    {
        return $"{Year} -- {worktim}";
    }
}