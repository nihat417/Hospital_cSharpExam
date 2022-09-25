namespace Hospital_cSharpExam.Allmethods;
using Hospital_cSharpExam.Time;

public static class Staticmethods
{
    public static bool Checkrezervision(this Workdate workdate)
    {
        return !workdate.worktim._Isrezerved;
    }

    public static void Reezerv(this Workdate workdate)
    {
        workdate.worktim._Isrezerved = true;
    }
}