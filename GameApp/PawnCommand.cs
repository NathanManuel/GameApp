using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApp
{
    internal class PawnCommand:Command
    {
        private Operation _operation;
        private Pawn _pawn;

        public PawnCommand(Pawn calculator, Operation operation)
        {
            _pawn = calculator;
            _operation = operation;
        }

        public override void Execute()
        {
            _pawn.Move(_operation);
        }

        public override void UnExecute()
        {
            _pawn.Move(UndoOperation(_operation));
        }

        private Operation UndoOperation(Operation operation)
        {
            switch (operation)
            {
                case Operation.Up:
                    return Operation.Down;
                case Operation.Down:
                    return Operation.Up;
                case Operation.Right:
                    return Operation.Left;
                case Operation.Left:
                    return Operation.Right;
                default:
                    throw new ArgumentOutOfRangeException(nameof(operation), operation, null);
            }
        }
    }
}
