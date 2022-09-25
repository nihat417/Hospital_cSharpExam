namespace Hospital_cSharpExam;
using Hospital_cSharpExam.Allmethods;
using Start;
class Program
{
    static void Main()
    {
        Start s = new();
        ConsoleSpinner animation = new();

        animation.Logo();
        s.startfunc();
    }
    

}