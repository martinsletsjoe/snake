using System.Security.Principal;

namespace Snake;

public class Player
{
    private readonly char _form;
    public int PositionY;
    public int PositionX;
    private int _length;

    public Player()
    {
        PositionX = 20;
        PositionY = 20;
        _form = 'X';
        _length = 8;
    }


    public void Show(int width)
    {
        for (int i = 0; i < _length; i++)
        {
            int effectiveX = (PositionX + i) % width;

            Console.SetCursorPosition(effectiveX, PositionY);
            Console.Write(_form);
        }
    }

    public void HandleInput(int width, int height)
    {
        if (Console.KeyAvailable)
        {
            var key = Console.ReadKey(true).Key;
            switch (key)
            {
                case ConsoleKey.UpArrow:
                    MoveVertically(-1, height); // Move up
                    break;
                case ConsoleKey.DownArrow:
                    MoveVertically(1, height);
                    break;
                case ConsoleKey.LeftArrow:
                    MoveHorizontally(-1, width);
            }
        }
    }


    public void MoveHorizontally(int width)
    {
        PositionY = (PositionY +1) % width;
    }

    public void MoveVertically(int height)
    {
        PositionX = (PositionX + 1) % height;
    }



}