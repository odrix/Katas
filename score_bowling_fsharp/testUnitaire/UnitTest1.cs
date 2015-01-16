using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace testUnitaire
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DeuxLancer4et3_score7()
        {
            var lances = new List<int>();
            lances.Add(4);
            lances.Add(3);
            int score = BowlingScore.CalculScore(lances.ToArray());
            Assert.AreEqual(7, score);
        }

        [TestMethod]
        public void QuatreLancer4et3Puis2et2_score11()
        {
            int score = BowlingScore.CalculScore(new [] {4,3,2,2});
            Assert.AreEqual(11, score);
        }

        [TestMethod]
        public void SparePuis2et2_score16()
        {
            int score = BowlingScore.CalculScore(new [] { 5, 5, 2, 2 });
            Assert.AreEqual(16, score);
        }

        [TestMethod]
        public void DixSpareDeSuiteEt5_score168()
        {
            var lances = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                lances.Add(7);
                lances.Add(3);
            }
            lances.Add(5);
            int score = BowlingScore.CalculScore(lances.ToArray());
            Assert.AreEqual(168, score);
        }

        [TestMethod]
        public void StrickPuis5et3_score26()
        {
            int score = BowlingScore.CalculScore(new[] { 10, 5, 3});
            Assert.AreEqual(26, score);
        }

        [TestMethod]
        public void QueDesStrick_score300()
        {
            var lances = new List<int>();
            for (int i = 0; i < 12; i++)
            {
                lances.Add(10);
            }
            int score = BowlingScore.CalculScore(lances.ToArray());
            Assert.AreEqual(300, score);
        }
    }
}
