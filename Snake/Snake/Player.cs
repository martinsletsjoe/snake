using System.Security.Principal;

namespace Snake;

public class Player
{
    private readonly char _head;
    public int PositionY;
    public int PositionX;
    private int _length;
    private Direction _currentDirection;
    private Queue<(int, int)> _bodyPositions;

    public Player()
    {
        PositionX = 20;
        PositionY = 20;
        _head = '0';
        _length = 2;
        _currentDirection = Direction.Right;
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
        switch (_currentDirection)
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
                    if (_currentDirection != Direction.Down) _currentDirection = Direction.Up;
                    break;
                case ConsoleKey.DownArrow:
                    if (_currentDirection != Direction.Up) _currentDirection = Direction.Down;
                    break;
                case ConsoleKey.LeftArrow:
                    if (_currentDirection != Direction.Right) _currentDirection = Direction.Left;
                    break;
                case ConsoleKey.RightArrow:
                    if(_currentDirection != Direction.Left) _currentDirection = Direction.Right;
                    break;
            }
        }
    }
}   