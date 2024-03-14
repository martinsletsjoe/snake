using System.Security.Principal;

namespace Snake;

public class Player
{
    private readonly char _form;
    public int PositionY;
    public int PositionX;
    private int _length;
    private Direction _currentDirection;

    public Player()
    {
        PositionX = 20;
        PositionY = 20;
        _form = 'X';
        _length = 8;
        _currentDirection = Direction.Right;
    }


    public void Show(int width, int height)
    {
        for (int i = 0; i < _length; i++)
        {
            int effectiveX = (PositionX + i) % width;

            Console.SetCursorPosition(effectiveX, PositionY);
            Console.Write(_form);
        }

        Move(width, height);
    }

    public void ChangeDirection(Direction newDirection)
    {
        _currentDirection = newDirection;
    }

    public void Move(int width, int height)
    {
        switch (_currentDirection)
        {
            case Direction.Up:
                PositionY = (PositionY > 0) ? PositionY - 1 : height - 1;
                break;
            case Direction.Down:
                PositionY = (PositionY + 1) % height;
                break;
            case Direction.Left:
                PositionX = (PositionX > 0) ? PositionX - 1 : width - 1;
                break;
            case Direction.Right:
                PositionX = (PositionX +1 ) % width;
                break;
        }
    }

    public void HandleInput()
    {
        if (Console.KeyAvailable)
        {
            var key = Console.ReadKey(true).Key;
            switch (key)
            {
                case ConsoleKey.UpArrow:
                    ChangeDirection(Direction.Up);
                    break;
                case ConsoleKey.DownArrow:
                    ChangeDirection(Direction.Down);
                    break;
                case ConsoleKey.LeftArrow:
                    ChangeDirection(Direction.Left);
                    break;
                case ConsoleKey.RightArrow:
                    ChangeDirection(Direction.Right);
                    break;
            }
        }
    }
}   
//public void HandleInput(int Width, int Height)
//{
//    if (Console.KeyAvailable)
//    {
//        var key = Console.ReadKey(true).Key;
//        switch (key)
//        {
//            case ConsoleKey.UpArrow:
//                MoveVertically(-1, Height); // Move up
//                break;
//            case ConsoleKey.DownArrow:
//                MoveVertically(1, Height);
//                break;
//            case ConsoleKey.LeftArrow:
//                Move(-1, Width);
//        }
//    }
//}