namespace Doctor;
using Human;
using Hospital_cSharpExam.Time;

public class Doctor:Human
{
    public Guid _id = Guid.NewGuid();
    public List<Worktime> _worktimes { get; set; }

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
