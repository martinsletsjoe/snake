namespace Snake;

public class Food
{
    public char Form;
    public int PositionX;
    public int PositionY;
    private Random _random;


    public Food(int x, int y)
    {
        Form = 'M';
        PositionX = x;
        PositionY = y;
        _random = new Random();
    }

    public void relocate()
    {
        PositionX = _random.Next(Console.WindowWidth);
        PositionY = _random.Next(Console.WindowHeight);
    }

    public void Show()
    {
        Console.SetCursorPosition(PositionX, PositionY);
        Console.Write(Form);
    }
}