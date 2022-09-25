namespace Hospital_cSharpExam.Humans;

public class ClientFormat
{
    public static string nameform()
    {
        while (true)
        {
            Console.WriteLine('\n');
            Console.ForegroundColor = ConsoleColor.White;
            Console.CursorLeft = 50;
            Console.WriteLine("Enter name:");
            Console.CursorLeft = 50;
            var name = Console.ReadLine();
            Console.Clear();
            if (name.Length > 0)
                return name;
            else
            {
                Console.WriteLine('\n');
                Console.Clear();
                Console.CursorLeft = 50;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("wrong lenght");
                continue;
            }
        }
    }

    public static string surnameform()
    {
        while (true)
        {
            Console.WriteLine('\n');
            Console.ForegroundColor = ConsoleColor.White;
            Console.CursorLeft = 50;
            Console.WriteLine("Enter Surname:");
            Console.CursorLeft = 50;
            var surname = Console.ReadLine();
            Console.Clear();
            if (surname.Length > 2)
                return surname;
            else
            {
                Console.WriteLine('\n');
                Console.Clear();
                Console.CursorLeft = 50;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong Length Surname");
                continue;
            }
        }
    }

    public static string emailformat()
    {
        while (true)
        {
            Console.WriteLine('\n');
            Console.ForegroundColor = ConsoleColor.White;
            Console.CursorLeft = 50;
            Console.WriteLine("Enter your email");
            Console.CursorLeft = 50;
            var mail = Console.ReadLine();
            Console.Clear();

            if (mail.EndsWith("@gmail.com") && mail.Length > 10)
                return mail;
            else
            {
                Console.WriteLine('\n');
                Console.CursorLeft = 50;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong email format or length!");
                continue;
            }

        }
    }

    public static string numberformat()
    {
        while (true)
        {
            Console.WriteLine('\n');
            Console.ForegroundColor = ConsoleColor.White;
            Console.CursorLeft = 50;
            Console.WriteLine("Enter number");
            Console.CursorLeft = 50;
            var phoneNumber = Console.ReadLine();
            Console.Clear();

            if (phoneNumber.StartsWith("055") || phoneNumber.StartsWith("050") || phoneNumber.StartsWith("070") || phoneNumber.StartsWith("077") || phoneNumber.StartsWith("070") && phoneNumber.Length > 9)
                return phoneNumber;
            else
            {
                Console.WriteLine('\n');
                Console.Clear();
                Console.CursorLeft = 50;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("wrong format or length");
                continue;
            }
        }
    }

}
