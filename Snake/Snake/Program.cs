namespace Snake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var player = new Player();
            var food = new Food();


            int height = 30;
            int width = height * 2; // Assuming this is within your screen's capability.



            Console.SetWindowSize(width, height);
            // Ensure the buffer size is at least as large as the window size to avoid scrolls.
            Console.SetBufferSize(width, height); // This line is added to adjust the buffer size.

            while (true)
            {
                Console.Clear();
                food.Show(width, height);
                player.Show(width);
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
