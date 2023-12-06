using Microsoft.VisualStudio.TestTools.UnitTesting;
using QueenAttack.Models;
using System.Collections.Generic;
using System;


namespace QueenAttack.Tests
{
    [TestClass]
    public class QueenTests
    {
        // First test I can think of: obect can create a constructor... THis test can also be regarded as checking if Queen constructor exists at all... Never forget, C# creates an empty constructor for me even though I haven't created the constructor myself. Thank you C# :)

        [TestMethod]
        public void QueenConstructor_CreatesAnInstanceOfObject_Queen()
        {
            Queen myQueen = new Queen(5, 2);
            Assert.AreEqual(typeof(Queen) ,myQueen.GetType());
        }
        // =bn

        // Second Test: Getting X coordinate for Queen
        [TestMethod]
        public void GetXForQueen_GetsTheXCoordinateForQueen_Int()
        {
            // Arrange
            int newQueenValX = 5;
            Queen myQueen = new Queen(newQueenValX, 2);
            int expectedVal = 5;
            
            // Act
            int actualVal = myQueen.QueenX;

            // Assert
            Assert.AreEqual(expectedVal, actualVal);
        }

        // Third Test: Setting X coordinate for Queen
        [TestMethod]
        public void SetXForQueen_SetsTheXCoordinateForQueen_Void()
        {
            // Arrange
            int expectedVal = 5;
            Queen myQueen = new Queen(expectedVal, 2);
            
            // Act
            myQueen.QueenX = expectedVal ;

            // Assert
            Assert.AreEqual(expectedVal, myQueen.QueenX);
        }

        // Fourth Test: Getting Y coordinate for Queen
        [TestMethod]
        public void GetYForQueen_GetsTheYCoordinateForQueen_Int()
        {
            // Arrange
            int newQueenValY = 5;
            Queen myQueen = new Queen(2, newQueenValY);
            int expectedVal = 5;
            
            // Act
            int actualVal = myQueen.QueenY;

            // Assert
            Assert.AreEqual(expectedVal, actualVal);
        }

        // Fifth Test: Setting Y coordinate for Queen
        [TestMethod]
        public void SetYForQueen_SetsTheYCoordinateForQueen_Int()
        {
            // Arrange
            int expectedVal = 5;
            Queen myQueen = new Queen(2, expectedVal);
            
            // Act
            myQueen.QueenY = expectedVal;

            // Assert
            Assert.AreEqual(expectedVal, myQueen.QueenY);
        }

        // Sixth Test: Determines If Queen Can Attack X Coordinate of other piece
        [TestMethod]
        public void CanQueenAttack_DeterminesIfQueenCanAttackXCoordinate_Bool()
        {
            // In chess, the board is often represented as an 8x8 grid, and each square on the grid is identified by a pair of coordinates (X, Y). The X coordinate represents the column, and the Y coordinate represents the row.
            // Arrange
            int pieceXVal = 1;
            int pieceYVal = 4;
            Queen myQueen = new Queen(1, 2);
            
            // Act
            // myQueen.QueenY = expectedVal;
            bool result = myQueen.CanQueenAttack(pieceXVal, pieceYVal);
            bool myExpectedAns = true;

            // Assert
            Assert.AreEqual(myExpectedAns, result);
            // Test passed because Queen and piece has the same X coordinate(X value: 1, 1)
        }

        // Seventh Test: Determines If Queen Can Attack Y Coordinate of other piece
        [TestMethod]
        public void CanQueenAttack_DeterminesIfQueenCanAttackYCoordinate_Bool()
        {
            // In chess, the board is often represented as an 8x8 grid, and each square on the grid is identified by a pair of coordinates (X, Y). The X coordinate represents the column, and the Y coordinate represents the row.
            // Arrange
            int pieceXVal = 3;
            int pieceYVal = 6;
            Queen myQueen = new Queen(2, 6);
            
            // Act
            // myQueen.QueenY = expectedVal;
            bool result = myQueen.CanQueenAttack(pieceXVal, pieceYVal);
            bool myExpectedAns = true;

            // Assert
            Assert.AreEqual(myExpectedAns, result);
            // Test passed because Queen and piece has the same Y coordinate(X value: 6, 6)
        }

        // Eight Test: Determines If Queen Can Attack other piece if they are both positioned diagonally along the main diagonal of the chessboard
        [TestMethod]
        public void CanQueenAttack_DeterminesIfQueenCanAttackDiagonalPieceCase1_Bool()
        {
            // In chess, the board is often represented as an 8x8 grid, and each square on the grid is identified by a pair of coordinates (X, Y). The X coordinate represents the column, and the Y coordinate represents the row.
            // Arrange
            int pieceXVal = 4;
            int pieceYVal = 4;
            Queen myQueen = new Queen(7, 7);
            
            // Act
            // myQueen.QueenY = expectedVal;
            bool result = myQueen.CanQueenAttack(pieceXVal, pieceYVal);
            bool myExpectedAns = true;

            // Assert
            Assert.AreEqual(myExpectedAns, result);
           
        }

        //  Ninth Test: Determines If Queen Can Attack other piece if they are both positioned diagonally along a diagonal line
        [TestMethod]
        public void CanQueenAttack_DeterminesIfQueenCanAttackDiagonalPieceTestCase2_Bool()
        {
            // In chess, the board is often represented as an 8x8 grid, and each square on the grid is identified by a pair of coordinates (X, Y). The X coordinate represents the column, and the Y coordinate represents the row.
            // Arrange
            int pieceXVal = 2;
            int pieceYVal = 6;
            Queen myQueen = new Queen(5, 3);
            
            // Act
            // myQueen.QueenY = expectedVal;
            bool result = myQueen.CanQueenAttack(pieceXVal, pieceYVal);
            bool myExpectedAns = true;

            // Assert
            Assert.AreEqual(myExpectedAns, result);
            // Test passed, Queen(5,3) other piece(2,6)... 5-2=3 and 6-2=3... Which makes them diagonal along a diagonal line
            
        }

        //  Tenth Test: Determines If Queen Canot attack other piece
        [TestMethod]
        public void CanQueenAttack_DeterminesIfQueenCannotAttackOtherPiece_Bool()
        {
            // In chess, the board is often represented as an 8x8 grid, and each square on the grid is identified by a pair of coordinates (X, Y). The X coordinate represents the column, and the Y coordinate represents the row.
            // Arrange
            int pieceXVal = 1;
            int pieceYVal = 7;
            Queen myQueen = new Queen(2, 5);
            
            // Act
            // myQueen.QueenY = expectedVal;
            bool result = myQueen.CanQueenAttack(pieceXVal, pieceYVal);
            bool myExpectedAns = false;

            // Assert
            Assert.AreEqual(myExpectedAns, result);
            // Test passed, Queen(5,3) other piece(2,6)... 5-2=3 and 6-2=3... Which makes them diagonal along a diagonal line
            
        }
    }
}