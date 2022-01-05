namespace GameApp
{
    internal class Pawn
    {
        private int _heigth = 1;
        private int _length = 0;

        List<string> horizontal = new List<string>() { "A", "B", "C", "D", "E", "F", "G", "H" };

        public void Move(Operation operation)
        {
           
                switch (operation)
                {
                    case Operation.Up: if (_heigth < 8) _heigth += 1; break;
                    case Operation.Down: if (_heigth > 1) _heigth -= 1; break;
                    case Operation.Right:if(_length < 8) _length += 1; break;
                    case Operation.Left: if(_length > 1) _length -= 1; break;
                }
                Console.WriteLine($"Current value = {_heigth}{horizontal[_length]} (after {operation})");
        }


    }
}
