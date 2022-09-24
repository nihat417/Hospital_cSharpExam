namespace Department;
using Doctor;

public class Department
{
    public string departmentsname { get; set; }
    public List<Doctor> _doctors { get; set; }

    public Department()
    {
        _doctors = new List<Doctor>();
    }

    public override string ToString()
    {
        return $"Department Name: {departmentsname}";
    }
}
