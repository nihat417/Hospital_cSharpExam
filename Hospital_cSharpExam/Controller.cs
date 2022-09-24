static class Control
{
    public static void MySetColor(ConsoleColor foreground, ConsoleColor background)
    {
        Console.ForegroundColor = foreground;
        Console.BackgroundColor = background;
    }

    public static bool Keyboard(ref int select, int count)
    {
        ConsoleKey keyboard = Console.ReadKey().Key;

        switch (keyboard)
        {
            case ConsoleKey.UpArrow:
            case ConsoleKey.LeftArrow:
            case ConsoleKey.W:
            case ConsoleKey.A:
                if (select == 0)
                    select = count;
                select--;
                return true;
            case ConsoleKey.DownArrow:
            case ConsoleKey.RightArrow:
            case ConsoleKey.S:
            case ConsoleKey.D:
                select++;
                select %= count;
                return true;
            case ConsoleKey.Enter:
                return false;
            default:
                return true;
        }
    }

    public static int GetSelect(string selection, string[] selections)
    {
        int select = default;
        int selectionsCount = Convert.ToInt32(selections.Length);

        bool check = true;
        while (check)
        {
            Console.Clear();
            Console.WriteLine(selection);

            for (int i = 0; i < selectionsCount; i++)
            {
                char axe = ' ';
                if (i == select)
                {
                    MySetColor(ConsoleColor.DarkYellow, ConsoleColor.White);
                    axe = ' ';
                }

                Console.WriteLine($" {axe} {selections[i]}");
                Console.ResetColor();
            }

            check = Keyboard(ref select, selectionsCount);
        }

        return select;
    }
}