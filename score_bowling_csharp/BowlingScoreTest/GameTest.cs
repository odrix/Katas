using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework ;
using BowlingScore;

namespace BowlingScoreTest
{
    public class GameTest
    {
        [Test]
        public void GameOneRollKnockdown4PinsScore0()
        {
            Game game = new Game();
            game.Roll(4);

            Assert.AreEqual(0, game.Score);
        }

        [Test]
        public void Game2RollKnockdown4plus3PinsScore7()
        {
            Game game = new Game();
            game.Roll(4);
            game.Roll(3);

            Assert.AreEqual(7, game.Score);
        }

        [Test]
        public void Game3RollKnockdown4Plus3Plus8PinsScore7()
        {
            Game game = new Game();
            game.Roll(4);
            game.Roll(3);
            game.Roll(8);

            Assert.AreEqual(7, game.Score);
        }

        [Test]
        public void Game4RollKnockdown4Plus3Plus8PinsPlusSpareScore7()
        {
            Game game = new Game();
            game.Roll(4);
            game.Roll(3);
            game.Roll(8);
            game.Roll(2); //Spare

            Assert.AreEqual(7, game.Score);
        }

        [Test]
        public void Game5RollKnockdown4Plus3Plus8PlusSparePlus5PinsScore22()
        {
            Game game = new Game();
            game.Roll(4);
            game.Roll(3);
            game.Roll(8);
            game.Roll(2); //Spare
            game.Roll(5);

            Assert.AreEqual(22, game.Score);
        }

        [Test]
        public void Game6RollKnockdown4Plus3Plus8PlusSparePlus5Plus2PinsScore29()
        {
            Game game = new Game();
            game.Roll(4);
            game.Roll(3);
            game.Roll(8);
            game.Roll(2); //Spare
            game.Roll(5);
            game.Roll(2);

            Assert.AreEqual(29, game.Score);
        }

        [Test]
        public void Game3RollKnockdown4Plus3PlusStrikeScore7()
        {
            Game game = new Game();
            game.Roll(4);
            game.Roll(3);
            game.Roll(10); //strike

            Assert.AreEqual(7, game.Score);
        }

        [Test]
        public void Game4RollKnockdown4Plus3PlusStrikePlus4PinsScore7()
        {
            Game game = new Game();
            game.Roll(4);
            game.Roll(3);
            game.Roll(10); //strike
            game.Roll(4);

            Assert.AreEqual(7, game.Score);
        }

        [Test]
        public void Game4RollKnockdown4Plus3PlusStrikePlus4Plus3PinsScore31()
        {
            Game game = new Game();
            game.Roll(4);
            game.Roll(3);
            game.Roll(10); //strike
            game.Roll(4);
            game.Roll(3);

            Assert.AreEqual(31, game.Score);
        }

        [Test]
        public void Game2StrikeScore0()
        {
            Game game = new Game();
            game.Roll(10); //strike
            game.Roll(10); //strike
            
            Assert.AreEqual(0, game.Score);
        }

        [Test]
        public void Game3StrikesScore30()
        {
            Game game = new Game();
            game.Roll(10); //strike
            game.Roll(10); //strike
            game.Roll(10); //strike

            Assert.AreEqual(30, game.Score);
        }

        [Test]
        public void Game3StrikesPlus5PinsScore55()
        {
            Game game = new Game();
            game.Roll(10); //strike
            game.Roll(10); //strike
            game.Roll(10); //strike
            game.Roll(5);

            Assert.AreEqual(55, game.Score);
        }

        [Test]
        public void Game3StrikesPlus5Plus3PinsScore73()
        {
            Game game = new Game();
            game.Roll(10); //strike  ==> 30
            game.Roll(10); //strike  ==> 25
            game.Roll(10); //strike  ==> 18
            game.Roll(5);
            game.Roll(3);  // 8

            Assert.AreEqual(81, game.Score);
        }

        [Test]
        public void GodPlayScore300()
        {
            Game game = new Game();
            for (int i = 0; i < 12; i++)
            {
                game.Roll(10); 
            }

            Assert.AreEqual(300, game.Score);
        }
    }
}
