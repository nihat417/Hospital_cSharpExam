namespace Human;

public abstract class Human
{
    public string _name { get; set; }
    public string _surname { get; set; }

    public Human(string name,string surname)
    {
        _name = name;
        _surname = surname;
    }

    public override string ToString()
    {
        return $"Name -- {_name}\nSuname -- {_surname}";
    }
}
