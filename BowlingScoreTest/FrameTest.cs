using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using BowlingScore;

namespace BowlingScoreTest
{
    public class FrameTest
    {
        [Test]
        public void FrameOneRollKnockDown4PinsSpareNOK()
        {
            Frame frame = new Frame();
            frame.Roll(4);

            Assert.AreEqual(false, frame.IsSpare);
        }

        [Test]
        public void FrameOneRollKnockDown4Plus6PinsSpareOK()
        {
            Frame frame = new Frame();
            frame.Roll(4);
            frame.Roll(6);

            Assert.AreEqual(true, frame.IsSpare);
        }

        [Test]
        public void FrameOneRollKnockDown0Plus10PinsSpareOK()
        {
            Frame frame = new Frame();
            frame.Roll(0);
            frame.Roll(10);

            Assert.AreEqual(true, frame.IsSpare);
        }
    }
}
