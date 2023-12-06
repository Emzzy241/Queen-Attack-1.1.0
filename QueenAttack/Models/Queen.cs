using System;

namespace QueenAttack.Models
{
    public class Queen
    {
        // Working with the RGR(Red, Green, Refactor) workflow

        public int QueenX { get; set; }
        public int QueenY { get; set; }
        
        
        // private int _queenY;
        // =bn

        public Queen(int myQueenX, int myQueenY)
        {
            QueenX = myQueenX;
            QueenY = myQueenY;
        }
        // A Queen class method
        // The Queen class should have a method that takes X and a Y coordinate as arguments, and returns true if the queen can attack the given space, and false if it cannot.
        public bool CanQueenAttack(int pieceX, int pieceY)
        {
            if(QueenX == pieceX || QueenY == pieceY || Math.Abs(QueenX - pieceX) == Math.Abs(QueenY - pieceY))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // THe CanQueenAttack() method above checks for:
        // Horizontal Attack (QueenX == pieceX): If the queen and the other piece share the same X coordinate. The X coordinate represents the column, and the Y coordinate represents the row. Coordinate consists of 2 values


    
    }   
}