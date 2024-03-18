namespace Snake;

public class Game
{
    private int _score;

    public Game()
    {
        _score = 0;
    }

    


    Player player = new() {PositionX = 10, PositionY = 10};
    Board board = new();
    Food food = new(15,10);

    public void GameLoop()
    {
        int sleepTimeHorizontal = 100;
        int sleepTimeVertical = 200;

        Console.SetWindowSize(board.Width, board.Height);
        // Ensure the buffer size is at least as large as the window size to avoid scrolls.
        Console.SetBufferSize(board.Width, board.Height); // This line is added to adjust the buffer size.

        while (true)
        {
            Console.Clear();
            Console.WriteLine(_score);

            if (food.PositionX == player.PositionX && food.PositionY == player.PositionY)
            {
                _score++;
                food.relocate();
            }

            food.Show();
            //food.Show(Width, Height);
            player.HandleInput();
            player.Move(Console.WindowWidth, Console.WindowHeight);
            player.Show();



            if (player.CurrentDirection == Direction.Up || player.CurrentDirection == Direction.Down)
            {
                Thread.Sleep(sleepTimeVertical);
            }
            else
            {
                Thread.Sleep(sleepTimeHorizontal);
            }
        }
    }

    
}