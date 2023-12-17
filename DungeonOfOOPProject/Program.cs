internal class Program
{
    static int playerX = 0;
    static int playerY = 0;
    static int consoleWidth = 80;
    static int consoleHeight = 25;

    static void Main(string[] args)
    {
        Console.CursorVisible = false;
        DrawPlayer();

        while (true)
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);

                switch (key.Key)
                {
                    case ConsoleKey.LeftArrow:
                        MovePlayer(-1, 0);
                        break;
                    case ConsoleKey.RightArrow:
                        MovePlayer(1, 0);
                        break;
                    case ConsoleKey.UpArrow:
                        MovePlayer(0, -1);
                        break;
                    case ConsoleKey.DownArrow:
                        MovePlayer(0, 1);
                        break;
                    default:
                        break;
                }
            }
        }
    }

    static void DrawPlayer()
    {
        Console.SetCursorPosition(playerX, playerY);
        Console.Write("X");
    }

    static void MovePlayer(int deltaX, int deltaY)
    {
        int newX = playerX + deltaX;
        int newY = playerY + deltaY;

        if (newX >= 0 && newX < consoleWidth && newY >= 0 && newY < consoleHeight)
        {
            ClearPlayer();
            playerX = newX;
            playerY = newY;
            DrawPlayer();
        }
    }

    static void ClearPlayer()
    {
        Console.SetCursorPosition(playerX, playerY);
        Console.Write(" ");
    }
}
