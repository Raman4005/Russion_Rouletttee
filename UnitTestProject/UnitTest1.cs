using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using RussianRouletteAssignment;
namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        Game Obj_game = new Game(); // Declare the object of the game class
        [TestMethod]
        public void RandomNumberPositive() // test to check bulletload variable value with 0 to 7
        {
            Obj_game.load();
            Assert.IsTrue(Obj_game.bulletLoad < 7 && Obj_game.bulletLoad > 0);
        }

        // test to check bulletload variable value should not be greater than 7
        [TestMethod]
        public void RandomNumberNegative()
        {
            Obj_game.load();
            Assert.IsFalse(Obj_game.bulletLoad > 7);
        }
    }
}
