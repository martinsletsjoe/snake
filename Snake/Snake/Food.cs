namespace Snake;

public class Food
{
    public char Form;
    public int PositionX;
    public int PositionY;
    private Random _random;


    public Food()
    {
        Form = 'M';
        PositionX = 18;
        PositionY = 14;
        _random = new Random();
    }

    public void SpawnFood()
    {
        PositionX = _random.Next(Console.WindowWidth);
        PositionY = _random.Next(Console.WindowHeight);
        Console.SetCursorPosition(PositionX, PositionY);
        Console.Write(Form);
    }
}