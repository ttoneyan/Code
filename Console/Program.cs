using Library;
using static System.Console;
using ChessGame;

King king = new King();
king.Color = FigureColor.White;
king.Row=4;
king.Column=6;
king.hasMoved=false;

WriteLine($"King color is {king.Color}");
WriteLine($"King's position is {king.Row}, {king.Column}");
WriteLine($"King has moved {king.hasMoved}");

