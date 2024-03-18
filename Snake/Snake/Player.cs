using System.Security.Principal;

namespace Snake;

public class Player
{
    private readonly char _head;
    public int PositionY { get; set; }
    public int PositionX { get; set; }
    private int _length;
    public Direction CurrentDirection;
    private Queue<(int, int)> _bodyPositions;

    public Player()
    {
        PositionX = 10;
        PositionY = 10;
        _head = '0';
        _length = 2;
        CurrentDirection = Direction.Right;
        _bodyPositions = new Queue<(int, int)>();

        for (int i = 0; i < _length; i++)
        {
            _bodyPositions.Enqueue((PositionX-i, PositionY));
        }
    }


    public void Show()
    {
        foreach (var (x,y) in _bodyPositions)
        {
            Console.SetCursorPosition(x % Console.WindowWidth, y);
            Console.Write(_head);
        }
    }



    public void Move(int width, int height)
    {
        int nextX = PositionX, nextY = PositionY;
        switch (CurrentDirection)
        {
            case Direction.Up:
                nextY = (PositionY - 1 + height) % height; break;
            case Direction.Down:
                nextY = (PositionY + 1) % height; break;
            case Direction.Left:
                nextX = (PositionX - 1 + width) % width; break;
            case Direction.Right:
                nextX = (PositionX + 1) % width; break;
        }

        // Move head
        PositionX = nextX;
        PositionY = nextY;

        // update body
        _bodyPositions.Enqueue((PositionX, PositionY));
        if (_bodyPositions.Count > _length) _bodyPositions.Dequeue();
    }

    public void HandleInput()
    {
        if (Console.KeyAvailable)
        {
            var key = Console.ReadKey(true).Key;
            switch (key)
            {
                case ConsoleKey.UpArrow:
                    if (CurrentDirection != Direction.Down) CurrentDirection = Direction.Up;
                    break;
                case ConsoleKey.DownArrow:
                    if (CurrentDirection != Direction.Up) CurrentDirection = Direction.Down;
                    break;
                case ConsoleKey.LeftArrow:
                    if (CurrentDirection != Direction.Right) CurrentDirection = Direction.Left;
                    break;
                case ConsoleKey.RightArrow:
                    if(CurrentDirection != Direction.Left) CurrentDirection = Direction.Right;
                    break;
            }
        }
    }
}   