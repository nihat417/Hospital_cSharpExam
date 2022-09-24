namespace Start;
using Hospital;
using Department;
using Doctor;
using Staticmethods;
using Client;
using Hospital_cSharpExam.Time;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

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
            //

            Console.Clear();
            var depnames = hosp.departmentsname.Select(s => s.departmentsname).ToList();

            int selectDepartment = Convert.ToInt32(Control.GetSelect("", new string[] { $"{depnames[0]}", $"{depnames[1]}","Exit"}) + 1);
            int selecteddepartment= selectDepartment - 1;


            if (selectDepartment == 1)
            {
                var docsname = hosp.departmentsname[selecteddepartment]._doctors.Select(s => s._name).ToList();
                int selectdoctors = Convert.ToInt32(Control.GetSelect("", new string[] { $"{docsname[0]}", $"{docsname[1]}", $"{docsname[2]}"}) + 1);
                int selecteddoctor = selectdoctors - 1;
                var worktimesdoc = hosp.departmentsname[selecteddepartment]._doctors[selecteddoctor]._worktimes.Select(s => $"{s._startsession} : {s._startsession} --  {(s._Isrezerved ? "Reserved" : "Not Reserved")}").ToList();
                if (selectdoctors == 1)
                {
                    while (true)
                    {
                        var selecttime = Convert.ToInt32(Control.GetSelect("", new string[] { $"{worktimesdoc[0]}", $"{worktimesdoc[1]}", $"{worktimesdoc[2]}", "Back" }) + 1);
                        var doctor = hosp.departmentsname[selecteddepartment]._doctors[selecteddoctor];

                        if (selecttime - 1 == 3)
                            break;

                        if (doctor.Checkrezervision(selecttime - 1))
                        {
                            doctor.Reezerv(selecttime - 1);
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

                        if (selecttime - 1 == 3)
                            break;
                        if (doctor.Checkrezervision(selecttime - 1))
                        {
                            doctor.Reezerv(selecttime - 1);
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

                        if (selecttime - 1 == 3)
                            break;
                        if (doctor.Checkrezervision(selecttime - 1))
                        {
                            doctor.Reezerv(selecttime - 1);
                            break;
                        }
                    }
                }
                //yuxardaki bunun optimizasya olnmus versyasidir

                //else if (selectdocors == 3)
                //{
                //    var worktimesdoc = hosp.departmentsname[0]._doctors[2]._worktimes.Select(s => $"{s._startsession._hour} : {s._startsession._minute} -- {s._endsession._hour} :{s._endsession._minute} -- {s._Isrezerved}").ToList();
                //    while (true)
                //    {
                //        var selecttime = Convert.ToInt32(Control.GetSelect("", new string[] { $"{worktimesdoc[0]}", $"{worktimesdoc[1]}", $"{worktimesdoc[2]}" }) + 1);
                //        if (selecttime == 1 && hosp.departmentsname[0]._doctors[2]._worktimes[0]._Isrezerved == false)
                //        {
                //            hosp.departmentsname[0]._doctors[2]._worktimes[0]._Isrezerved = true;
                //            break;
                //        }
                //        else if (selecttime == 2 && hosp.departmentsname[0]._doctors[2]._worktimes[1]._Isrezerved == false)
                //        {
                //            hosp.departmentsname[0]._doctors[2]._worktimes[1]._Isrezerved = true;
                //            break;
                //        }
                //        else if (selecttime == 3 && hosp.departmentsname[0]._doctors[2]._worktimes[2]._Isrezerved == false)
                //        {
                //            hosp.departmentsname[0]._doctors[2]._worktimes[2]._Isrezerved = true;
                //            break;
                //        }
                //        else
                //        {
                //            Console.WriteLine("bura rezerv olunub");
                //            continue;
                //        }
                //    }
                //}
            }
            else if (selectDepartment == 2)
            {
                var docsname = hosp.departmentsname[selecteddepartment]._doctors.Select(s => s._name).ToList();
                int selectdoctors = Convert.ToInt32(Control.GetSelect("", new string[] { $"{docsname[0]}", $"{docsname[1]}", $"{docsname[2]}" }) + 1);
                int selecteddoctor = selectdoctors - 1;
                var worktimesdoc = hosp.departmentsname[selecteddepartment]._doctors[selecteddoctor]._worktimes.Select(s => $"{s._startsession} : {s._startsession} --  {(s._Isrezerved ? "Reserved" : "Not Reserved")}").ToList();
                if (selectdoctors == 1)
                {
                    while (true)
                    {
                        var selecttime = Convert.ToInt32(Control.GetSelect("", new string[] { $"{worktimesdoc[0]}", $"{worktimesdoc[1]}", $"{worktimesdoc[2]}", "Back" }) + 1);
                        var doctor = hosp.departmentsname[selecteddepartment]._doctors[selecteddoctor];

                        if (selecttime - 1 == 3)
                            break;
                        if (doctor.Checkrezervision(selecttime - 1))
                        {
                            doctor.Reezerv(selecttime - 1);
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

                        if (selecttime - 1 == 3)
                            break;
                        if (doctor.Checkrezervision(selecttime - 1))
                        {
                            doctor.Reezerv(selecttime - 1);
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

                        if (selecttime - 1 == 3)
                            break;
                        if (doctor.Checkrezervision(selecttime - 1))
                        {
                            doctor.Reezerv(selecttime - 1);
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
