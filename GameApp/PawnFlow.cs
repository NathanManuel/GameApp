using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApp
{
    internal class PawnFlow
    {
        private readonly Pawn _pawn;

        private readonly List<PawnCommand> _commandHistory = new List<PawnCommand>();

        public PawnFlow(Pawn calculator)
        {
            _pawn = calculator;
        }

        public void ExecuteOperation(Operation operation)
        {
            var calcCommand = new PawnCommand(_pawn, operation);
            calcCommand.Execute();
            _commandHistory.Add(calcCommand);
        }

        public void Undo()
        {
            var lastCommand = _commandHistory.LastOrDefault();
            if (lastCommand == null) return;

            lastCommand.UnExecute();
            _commandHistory.Remove(lastCommand);
        }

        public void Redo()
        {
            var lastCommand = _commandHistory.LastOrDefault();
            lastCommand?.Execute();
        }
    }
}
