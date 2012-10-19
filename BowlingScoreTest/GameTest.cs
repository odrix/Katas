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
        public void GameOneRollKnockdown4Pins()
        {
            Game game = new Game();
            game.Roll(4);

            Assert.AreEqual(0, game.Score);
        }

        [Test]
        public void Game2RollKnockdown7Pins()
        {
            Game game = new Game();
            game.Roll(4);
            game.Roll(3);

            Assert.AreEqual(7, game.Score);
        }
    }
}
