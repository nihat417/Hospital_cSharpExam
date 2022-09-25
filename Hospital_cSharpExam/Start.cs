using Hospital_cSharpExam;

namespace Start;
using Hospital_cSharpExam.Time;
using Newtonsoft.Json;
using Hospital_cSharpExam.Humans;
using Hospital_cSharpExam.Hospital;
using Hospital_cSharpExam.Allmethods;

public class Start
{
    public void startfunc()
    {
        var hosp = File.Exists("Hospital.json") ? JsonConvert.DeserializeObject<Hospital>(File.ReadAllText("Hospital.json")) : new Hospital
        {
            _name = "222 nomreli xestexana",
            _location = "Xirdalan",
            departmentsname = new List<Department>
            {
                new Department()
                {
                    departmentsname="pediatriya",
                    _doctors=new List<Doctor>
                    {
                        new Doctor("samir","Aliyev"),
                        new Doctor("Kamil","Zeynalli"),
                        new Doctor("Natiq","Qafarzade"),
                    }
                },
                new Department()
                {
                    departmentsname="Travmatalogya",
                    _doctors=new List<Doctor>
                    {
                        new Doctor("Con","Smith"),
                        new Doctor("Alo","Roya"),
                        new Doctor("Nieki","Qafar"),
                    }
                }
            }

        };
        while (true)
        {

            foreach (var department in hosp.departmentsname)
            {
                foreach (var docs in department._doctors)
                {
                    docs._worktimes.Add(
                        new Worktime()
                        {
                            _startsession = new Time() { _hour = 10, _minute = 0 },
                            _endsession = new Time() { _hour = 11, _minute = 0 }
                        });
                    docs._worktimes.Add(
                        new Worktime()
                        {
                            _startsession = new Time() { _hour = 12, _minute = 0 },
                            _endsession = new Time() { _hour = 13, _minute = 0 }
                        });
                    docs._worktimes.Add(
                        new Worktime()
                        {
                            _startsession = new Time() { _hour = 14, _minute = 0 },
                            _endsession = new Time() { _hour = 15, _minute = 0 }
                        });
                }
            }

            //users
            
            Client.InputdatasClient();

            ConsoleSpinner spinner = new ConsoleSpinner();
            spinner.Delay = 300;
            int animationcounter = 0;
            Console.WriteLine("\n\n\n\n\n");
            while (true)
            {
                animationcounter += 1;
                Console.CursorLeft = 50;
                spinner.Turn(displayMsg: "Loading ", sequenceCode: 5);
                if (animationcounter == 15)
                    break;
            }
            
            


            Console.Clear();

            
            var depnames = hosp.departmentsname.Select(s => s.departmentsname).ToList();
            int selectDepartment = Convert.ToInt32(Control.GetSelect("", new string[] { $"{depnames[0]}", $"{depnames[1]}", "Exit" }) + 1);
            int selecteddepartment = selectDepartment - 1;

            if (selectDepartment == 1)
            {
                var docsname = hosp.departmentsname[selecteddepartment]._doctors.Select(s => s._name).ToList();
                int selectdoctors = Convert.ToInt32(Control.GetSelect("", new string[] { $"{docsname[0]}", $"{docsname[1]}", $"{docsname[2]}" }) + 1);
                int selecteddoctor = selectdoctors - 1;
                var worktimesdoc = hosp.departmentsname[selecteddepartment]._doctors[selecteddoctor]._worktimes.Select(s => $"{s._startsession} : {s._startsession} --  {(s._Isrezerved ? "Reserved" : "Not Reserved")}").ToList();

                Console.Clear();
                Console.CursorLeft = 50;
                Console.WriteLine("Enter a date (e.g. 22/12/1987): ");
                Console.CursorLeft = 50;
                DateTime inputtedDate = DateTime.Parse(Console.ReadLine());
                
                

                if (selectdoctors == 1)
                {                                                
                    while (true)
                    {                        
                        var selecttime = Convert.ToInt32(Control.GetSelect("", new string[] { $"{worktimesdoc[0]}", $"{worktimesdoc[1]}", $"{worktimesdoc[2]}", "Back" }) + 1);
                        var doctor = hosp.departmentsname[selecteddepartment]._doctors[selecteddoctor];
                        Workdate workdate = new Workdate(inputtedDate, hosp.departmentsname[selecteddepartment]._doctors[selecteddoctor]._worktimes[selecttime-1]);
                        if (selecttime - 1 == 3)
                            break;

                        if (workdate.Checkrezervision())
                        {
                            workdate.Reezerv();
                            Console.Clear();
                            animationcounter = 0;
                            while (true)
                            {
                                animationcounter += 1;
                                Console.CursorLeft = 50;
                                spinner.Turn(displayMsg: "Loading ", sequenceCode: 5);
                                if (animationcounter == 15)
                                    break;
                            }
                            Console.Clear();
                            Console.CursorLeft = 50;
                            Console.WriteLine($"Rezerv etdiniz twk:)");
                            Thread.Sleep(1000);
                            break;
                        }
                    }
                }
                else if (selectdoctors == 2)
                {
                    while (true)
                    {
                        var selecttime = Convert.ToInt32(Control.GetSelect("", new string[] { $"{worktimesdoc[0]}", $"{worktimesdoc[1]}", $"{worktimesdoc[2]}", "Back" }) + 1);
                        var doctor = hosp.departmentsname[selecteddepartment]._doctors[selecteddoctor];
                        Workdate workdate = new Workdate(inputtedDate, hosp.departmentsname[selecteddepartment]._doctors[selecteddoctor]._worktimes[selecttime - 1]);

                        if (selecttime - 1 == 3)
                            break;
                        if (workdate.Checkrezervision())
                        {
                            workdate.Reezerv();
                            Console.Clear();
                            animationcounter = 0;
                            while (true)
                            {
                                animationcounter += 1;
                                Console.CursorLeft = 50;
                                spinner.Turn(displayMsg: "Loading ", sequenceCode: 5);
                                if (animationcounter == 15)
                                    break;
                            }
                            Console.Clear();
                            Console.CursorLeft = 50;
                            Console.WriteLine($"Rezerv etdiniz twk:)");
                            Thread.Sleep(1000);
                            break;
                        }
                    }
                }
                else if (selectdoctors == 3)
                {

                    while (true)
                    {
                        var selecttime = Convert.ToInt32(Control.GetSelect("", new string[] { $"{worktimesdoc[0]}", $"{worktimesdoc[1]}", $"{worktimesdoc[2]}", "Back" }) + 1);
                        var doctor = hosp.departmentsname[selecteddepartment]._doctors[selecteddoctor];
                        Workdate workdate = new Workdate(inputtedDate, hosp.departmentsname[selecteddepartment]._doctors[selecteddoctor]._worktimes[selecttime - 1]);
                        if (selecttime - 1 == 3)
                            break;
                        if (workdate.Checkrezervision())
                        {
                            workdate.Reezerv();
                            Console.Clear();
                            animationcounter = 0;
                            while (true)
                            {
                                animationcounter += 1;
                                Console.CursorLeft = 50;
                                spinner.Turn(displayMsg: "Loading ", sequenceCode: 5);
                                if (animationcounter == 15)
                                    break;
                            }
                            Console.Clear();
                            Console.CursorLeft = 50;
                            Console.WriteLine($"Rezerv etdiniz twk:)");
                            Thread.Sleep(1000);
                            break;
                        }
                    }
                }
            }
            else if (selectDepartment == 2)
            {
                var docsname = hosp.departmentsname[selecteddepartment]._doctors.Select(s => s._name).ToList();
                int selectdoctors = Convert.ToInt32(Control.GetSelect("", new string[] { $"{docsname[0]}", $"{docsname[1]}", $"{docsname[2]}" }) + 1);
                int selecteddoctor = selectdoctors - 1;
                var worktimesdoc = hosp.departmentsname[selecteddepartment]._doctors[selecteddoctor]._worktimes.Select(s => $"{s._startsession} : {s._startsession} --  {(s._Isrezerved ? "Reserved" : "Not Reserved")}").ToList();

                Console.Clear();
                Console.CursorLeft = 50;
                Console.WriteLine("Enter a date (e.g. 22/12/1987): ");
                Console.CursorLeft = 50;
                DateTime inputtedDate = DateTime.Parse(Console.ReadLine());

                if (selectdoctors == 1)
                {
                    while (true)
                    {
                        var selecttime = Convert.ToInt32(Control.GetSelect("", new string[] { $"{worktimesdoc[0]}", $"{worktimesdoc[1]}", $"{worktimesdoc[2]}", "Back" }) + 1);
                        var doctor = hosp.departmentsname[selecteddepartment]._doctors[selecteddoctor];
                        Workdate workdate = new Workdate(inputtedDate, hosp.departmentsname[selecteddepartment]._doctors[selecteddoctor]._worktimes[selecttime - 1]);

                        if (selecttime - 1 == 3)
                            break;
                        if (workdate.Checkrezervision())
                        {
                            workdate.Reezerv();
                            Console.Clear();
                            animationcounter = 0;
                            while (true)
                            {
                                animationcounter += 1;
                                Console.CursorLeft = 50;
                                spinner.Turn(displayMsg: "Loading ", sequenceCode: 5);
                                if (animationcounter == 15)
                                    break;
                            }
                            Console.Clear();
                            Console.CursorLeft = 50;
                            Console.WriteLine($"Rezerv etdiniz twk:)");
                            Thread.Sleep(1000);
                            break;
                        }
                    }
                }
                else if (selectdoctors == 2)
                {
                    while (true)
                    {
                        var selecttime = Convert.ToInt32(Control.GetSelect("", new string[] { $"{worktimesdoc[0]}", $"{worktimesdoc[1]}", $"{worktimesdoc[2]}", "Back" }) + 1);
                        var doctor = hosp.departmentsname[selecteddepartment]._doctors[selecteddoctor];
                        Workdate workdate = new Workdate(inputtedDate, hosp.departmentsname[selecteddepartment]._doctors[selecteddoctor]._worktimes[selecttime - 1]);
                        if (selecttime - 1 == 3)
                            break;
                        if (workdate.Checkrezervision())
                        {
                            workdate.Reezerv();
                            Console.Clear();
                            animationcounter = 0;
                            while (true)
                            {
                                animationcounter += 1;
                                Console.CursorLeft = 50;
                                spinner.Turn(displayMsg: "Loading ", sequenceCode: 5);
                                if (animationcounter == 15)
                                    break;
                            }
                            Console.Clear();
                            Console.CursorLeft = 50;
                            Console.WriteLine($"Rezerv etdiniz twk:)");
                            Thread.Sleep(1000);
                            break;
                        }
                    }
                }
                else if (selectdoctors == 3)
                {
                    while (true)
                    {
                        var selecttime = Convert.ToInt32(Control.GetSelect("", new string[] { $"{worktimesdoc[0]}", $"{worktimesdoc[1]}", $"{worktimesdoc[2]}", "Back" }) + 1);
                        var doctor = hosp.departmentsname[selecteddepartment]._doctors[selecteddoctor];
                        Workdate workdate = new Workdate(inputtedDate, hosp.departmentsname[selecteddepartment]._doctors[selecteddoctor]._worktimes[selecttime - 1]);
                        if (selecttime - 1 == 3)
                            break;
                        if (workdate.Checkrezervision())
                        {
                            workdate.Reezerv();
                            Console.Clear();
                            animationcounter = 0;
                            while (true)
                            {
                                animationcounter += 1;
                                Console.CursorLeft = 50;
                                spinner.Turn(displayMsg: "Loading ", sequenceCode: 5);
                                if (animationcounter == 15)
                                    break;
                            }
                            Console.Clear();
                            Console.CursorLeft = 50;
                            Console.WriteLine($"Rezerv etdiniz twk:)");
                            Thread.Sleep(1000);
                            break;
                        }
                    }
                }
            }
            else if (selectDepartment == 3)
                break;
            File.WriteAllText("Hospital.json", JsonConvert.SerializeObject(hosp));
        }
    }
}