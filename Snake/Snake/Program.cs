namespace Snake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var game = new Game();

            game.GameLoop();

            //var player = new Player();
            //var board = new Board();
            //var food = new Food();



            //int sleepTimeHorizontal = 100;
            //int sleepTimeVertical = 200;


            //Console.SetWindowSize(board.Width, board.Height);
            //// Ensure the buffer size is at least as large as the window size to avoid scrolls.
            //Console.SetBufferSize(board.Width, board.Height); // This line is added to adjust the buffer size.

            //while (true)
            //{
            //    Console.Clear();
            //    food.Show();

            //    //food.Show(Width, Height);
            //    player.HandleInput();
            //    player.Move(Console.WindowWidth, Console.WindowHeight);
            //    player.Show();

            //    if (player.CurrentDirection == Direction.Up || player.CurrentDirection == Direction.Down)
            //    {
            //        Thread.Sleep(sleepTimeVertical);
            //    }
            //    else
            //    {
            //        Thread.Sleep(sleepTimeHorizontal);
            //    }
            //}
        }

    }
}


/* slangen
    - form
    - lengde
    - fart?
    - retning?
    -posisjon

 Mat
    - form
    - posisjon

 */
