namespace Hospital;
using Department;

public class Hospital
{
    public string? _name { get; set; }
    public string? _location { get; set; }
    public List<Department> departmentsname = new List<Department>();

   

    public override string ToString()
    {
        return $"Hospital Name -- {_name}\nLocation -- {_location}\nDepartments -- {departmentsname}";
    }
}
