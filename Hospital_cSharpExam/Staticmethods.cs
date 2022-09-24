namespace  Staticmethods;
using Doctor;
public static class Staticmethods
{
    public static bool Checkrezervision(this Doctor doctor, int sel)
    {
        return !doctor._worktimes[sel]._Isrezerved;
    }

    public static void Reezerv(this Doctor doctor, int sel)
    {
        doctor._worktimes[sel]._Isrezerved = true;
    }
}
