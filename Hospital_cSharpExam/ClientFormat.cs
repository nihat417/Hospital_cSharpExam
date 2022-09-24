namespace ClientFormat;

public class ClientFormat
{
    public static string nameform()
    {
        while(true)
        {
            Console.WriteLine("Enter name:");
            var name = Console.ReadLine();
            if (name.Length > 0)
                return name;
            else
            {
                Console.WriteLine("wrong lenght");
                continue;
            }
        }
    }

    public static string surnameform()
    {
        while(true)
        {
            Console.WriteLine("Enter Surname:");
            var surname = Console.ReadLine();
            if (surname.Length > 2)
                return surname;
            else
            {
                Console.WriteLine("Wrong Length Surname");
                continue;
            }
        }
    }

    public static string emailformat()
    {
        while (true)
        {
            Console.WriteLine("Enter your email");
            var mail = Console.ReadLine();

            if (mail.EndsWith("@gmail.com") && mail.Length > 10)
                 return mail;
            else
            {
                Console.WriteLine("Wrong email format or length!");
                continue;
            }
            
        }
    }

    public static string numberformat()
    {
        while (true)
        {
            Console.WriteLine("Enter phono number");
            var phoneNumber = Console.ReadLine();

            if (phoneNumber.StartsWith("055") || phoneNumber.StartsWith("050") || phoneNumber.StartsWith("070") || phoneNumber.StartsWith("077") || phoneNumber.StartsWith("070") && phoneNumber.Length > 9)
                return phoneNumber;
            else
            {
                Console.WriteLine("Enter wrong format or length");
                continue;
            }
        }
    }
}
