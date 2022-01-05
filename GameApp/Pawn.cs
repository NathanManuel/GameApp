namespace GameApp
{
    internal class Pawn
    {
        private int _heigth = 1;
        private int _length = 0;

        List<string> horizontal = new List<string>() { "A", "B", "C", "D", "E", "F", "G", "H" };

        public void Move(Operation operation)
        {
            if(_heigth >= 1 && _heigth < 8)
            {
            switch (operation)
            {
                case Operation.Up: _heigth += 1; break;
                case Operation.Down: _heigth -= 1; break;
                case Operation.Right: _length += 1; break;
                case Operation.Left: _length -= 1; break;
                }
            Console.WriteLine($"Current value = {_heigth}{horizontal[_length]} (after {operation})");
            }
        }

     
    }
}
