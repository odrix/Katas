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
        public void Frame2RollsKnockDown4Plus6PinsSpareOK()
        {
            Frame frame = new Frame();
            frame.Roll(4);
            frame.Roll(6);

            Assert.AreEqual(true, frame.IsSpare);
        }

        [Test]
        public void Frame2RollsKnockDown0Plus10PinsSpareOK()
        {
            Frame frame = new Frame();
            frame.Roll(0);
            frame.Roll(10);

            Assert.AreEqual(true, frame.IsSpare);
        }

        [Test]
        public void FrameOneRollKnockDown4PinsScore0()
        {
            Frame frame = new Frame();
            frame.Roll(4);

            Assert.AreEqual(0, frame.Score);
        }

        [Test]
        public void Frame2RollsKnockDown4Plus3PinsScore7()
        {
            Frame frame = new Frame();
            frame.Roll(4);
            frame.Roll(3);

            Assert.AreEqual(7, frame.Score);
        }

        [Test]
        public void Frame2RollsKnockDown4Plus6PinsScore0()
        {
            Frame frame = new Frame();
            frame.Roll(4);
            frame.Roll(6);

            Assert.AreEqual(0, frame.Score);
        }

        [Test]
        public void Frame2RollsKnockDown0Plus10PinsSCore0()
        {
            Frame frame = new Frame();
            frame.Roll(0);
            frame.Roll(10);

            Assert.AreEqual(0, frame.Score);
        }

        [Test]
        public void FrameOneRollKnockDown4PinsFinishNok()
        {
            Frame frame = new Frame();
            frame.Roll(4);

            Assert.AreEqual(false, frame.IsFinish);
        }

        [Test]
        public void Frame2RollsKnockDown4Plus3PinsFinishOK()
        {
            Frame frame = new Frame();
            frame.Roll(4);
            frame.Roll(3);

            Assert.AreEqual(true, frame.IsFinish);
        }

        [Test]
        public void Frame2RollsKnockDown4Plus6PinsFinishOk()
        {
            Frame frame = new Frame();
            frame.Roll(4);
            frame.Roll(6);

            Assert.AreEqual(true, frame.IsFinish);
        }

        [Test]
        public void Frame2RollsKnockDown0Plus10PinsFinishOk()
        {
            Frame frame = new Frame();
            frame.Roll(0);
            frame.Roll(10);

            Assert.AreEqual(true, frame.IsFinish);
        }


        [Test]
        public void FrameOneRollKnockDown4PinsIsStrikeNok()
        {
            Frame frame = new Frame();
            frame.Roll(4);

            Assert.AreEqual(false, frame.IsStrike);
        }

        [Test]
        public void Frame2RollsKnockDown4Plus3PinsIsStrikeNok()
        {
            Frame frame = new Frame();
            frame.Roll(4);
            frame.Roll(3);

            Assert.AreEqual(false, frame.IsStrike);
        }

        [Test]
        public void Frame2RollsKnockDown4Plus6PinsIsStrikeNok()
        {
            Frame frame = new Frame();
            frame.Roll(4);
            frame.Roll(6);

            Assert.AreEqual(false, frame.IsStrike);
        }

        [Test]
        public void Frame2RollsKnockDown10PinsIsStrikeOk()
        {
            Frame frame = new Frame();
            frame.Roll(10);

            Assert.AreEqual(true, frame.IsStrike);
        }
    }
}
