using System;

namespace GameApp

{
    class Program
    {
        static void Main(string[] args)
        {
            var pawn = new Pawn();
            var pawnFolw = new PawnFlow(pawn);
            pawnFolw.ExecuteOperation(Operation.Up);//2
            pawnFolw.ExecuteOperation(Operation.Up);//3
            pawnFolw.ExecuteOperation(Operation.Up);//4
            pawnFolw.ExecuteOperation(Operation.Down);//3
            pawnFolw.ExecuteOperation(Operation.Right);//B
            pawnFolw.ExecuteOperation(Operation.Right);//C
            pawnFolw.ExecuteOperation(Operation.Down);//2
            pawnFolw.ExecuteOperation(Operation.Down);//1
            pawnFolw.ExecuteOperation(Operation.Down);//1
            pawnFolw.ExecuteOperation(Operation.Up);//2
            pawnFolw.ExecuteOperation(Operation.Up);//3
            pawnFolw.Undo();//2
            pawnFolw.Redo();//3
            pawnFolw.ExecuteOperation(Operation.Up);//4
            pawnFolw.ExecuteOperation(Operation.Right);//D
            pawnFolw.ExecuteOperation(Operation.Up);//5
            pawnFolw.ExecuteOperation(Operation.Right);//E
            pawnFolw.ExecuteOperation(Operation.Up);//6
            pawnFolw.ExecuteOperation(Operation.Up);//7
            pawnFolw.ExecuteOperation(Operation.Up);//8
            pawnFolw.ExecuteOperation(Operation.Up);//8

            Console.ReadLine();
        }
    }
}
