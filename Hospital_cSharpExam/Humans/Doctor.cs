using Hospital_cSharpExam.Time;

namespace Hospital_cSharpExam.Humans;
public class Doctor : Human
{
    public Guid _id = Guid.NewGuid();
    public List<Worktime> _worktimes { get; set; }

    public Workdate Workdates { get; set; }

    public Doctor(string name, string surname)
        : base(name, surname)
    {
        _worktimes = new List<Worktime>();

    }

    public override string ToString()
    {
        return $"{base.ToString()}";
    }
}