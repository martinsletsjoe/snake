namespace Snake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var player = new Player();
            var board = new Board();
            var food = new Food();

            Console.CursorVisible = false;





            Console.SetWindowSize(board.Width, board.Height);
            // Ensure the buffer size is at least as large as the window size to avoid scrolls.
            Console.SetBufferSize(board.Width, board.Height); // This line is added to adjust the buffer size.

            while (true)
            {
                Console.Clear();
                food.SpawnFood();

                //food.Show(Width, Height);
                player.HandleInput();
                player.Move(Console.WindowWidth, Console.WindowHeight);
                player.Show();
                Thread.Sleep(100);

            }

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
