using System;
using System.Collections.Generic;

namespace QueenAttack.Models
{
    // Never forget once we do not put in any access modifier, C# resets to the default which is: internal access modifier. Internal is just like public, but it is only public within a certain assembly

    class Program
    {
           static void Main()
           {
                while (true)
                {
                    Console.WriteLine("Welcome to the Queen Attack game");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Remember, a chess board is divided into 8*8, ensure your values do not exceed it");
                    Console.WriteLine();
                    Console.WriteLine("To quit game, enter Ctrl+c");
                    Console.WriteLine();

            //  =bn
                    // Taking X value for other piece
                    Console.WriteLine("Enter the X value for Queen");
                    int queenValX = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    // Taking Y value for other piece
                    Console.WriteLine("Enter the Y value for Queen");
                    int queenValY = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine();
                    Queen newQueen = new Queen(queenValX, queenValY);
                    
                    
                    // Taking X value for other piece
                    Console.WriteLine();
                    Console.WriteLine("Enter the X value for any other Chess piece");
                    int pieceValX = int.Parse(Console.ReadLine());
                    
                    // Taking Y value for other piece
                    Console.WriteLine();
                    Console.WriteLine("Enter the Y value for any other Chess piece");
                    int pieceValY = int.Parse(Console.ReadLine());


                    Console.WriteLine();
                    Console.WriteLine();
                    bool result = newQueen.CanQueenAttack(pieceValX, pieceValY);

                    if (result == true)
                    {
                        
                        Console.WriteLine();
                        Console.WriteLine(" ---------------------------------------------------------------------");
                        Console.WriteLine($"Yes, the queen can attack the other chess piece");
                        Console.WriteLine(" ---------------------------------------------------------------------");
                        Console.WriteLine();
                    }
                    else if (result == false)
                    {
                        
                        Console.WriteLine();
                        Console.WriteLine(" ---------------------------------------------------------------------");
                        Console.WriteLine($"No, the queen cannot attack the other chess piece");
                        Console.WriteLine(" ---------------------------------------------------------------------");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Something is wrong, ensure you inserted the right coordinates for both Queen and the other chess piece. Lets Try again");
                        Console.WriteLine();
                        Console.WriteLine();
                        Main();
                    }


                }



           } 
    }
}