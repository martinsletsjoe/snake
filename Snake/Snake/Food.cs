namespace Snake;

public class Food
{
    public char Form;
    public int positionX;
    public int positionY;
    private Random random;
    public int startPosition;
    public int newFoodCount;


    public Food()
    {
        Form = 'f';
        startPosition = 0;
        newFoodCount = 0;
        positionX = 30;
        positionY = 30;
    }

    public void Show(int width, int height)
    {
        if(startPosition == newFoodCount) { 
            random = new Random();
            positionX = random.Next(width);
            positionY = random.Next(height);
            Console.SetCursorPosition(positionX, positionY);
            Console.Write(Form);
            startPosition++;
        }
        else
        {
            Console.SetCursorPosition(positionX, positionY);
            Console.Write(Form);
        }
    }
}