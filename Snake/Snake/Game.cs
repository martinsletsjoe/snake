//namespace Snake;

//public class Game
//{
//    private Food _food;
//    private Player _player;

//    private int _score;


//    private void MovePaddle()
//    {
//        if (Console.KeyAvailable)
//        {
//            var key = Console.ReadKey(true);
//            var moveLeft = key.Key == ConsoleKey.LeftArrow && _player.PositionX >= _paddleMoveDistance;
//            var moveRight = key.Key == ConsoleKey.RightArrow && _player.PositionX < Console.WindowWidth - _player.Form.Length;
//            if (moveLeft || moveRight)
//            {
//                var direction = moveLeft ? -1 : 1;
//                _player.ChangePosition(_player.PositionX + direction * 3 * _player.Form.Length / 4);
//            }
//        }
//    }
//}