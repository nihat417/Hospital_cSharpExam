namespace Client;
using ClientFormat;
using Human;
using Serilog;

public class Client : Human
{
    public string _email { get; set; }
    public string _number { get; set; }

    public Client(string name, string surname,string email,string number)
        : base(name, surname)
    {
        _email = email;
        _number = number;
    }

    public static void InputdatasClient()
    {
        Client a = new Client(ClientFormat.nameform(), ClientFormat.surnameform(), ClientFormat.emailformat(), ClientFormat.numberformat());
        
        string format = $"[\n{a}\n]\n";
        Log.Logger = new LoggerConfiguration()
            .WriteTo.File("users.json", outputTemplate: format).CreateLogger();
        Log.Information($"a {a}");
    }

    public override string ToString()
    {
        return $"{base.ToString()}\nEmail -- {_email}\nNumber -- {_number}";
    }
}
