using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codewars_Band_Name_Generator
{
    [TestClass]
    public class Kata
    {
        private void AssertShouldBe(string expect, string input)
        {
            Assert.AreEqual(expect, GetBandName(input));
        }

        [TestMethod]
        public void Input_bed_Should_The_Space_Bed()
        {
            AssertShouldBe("The Bed", "bed");
        }

        [TestMethod]
        public void Input_knife_Should_The_Space_Knife()
        {
            AssertShouldBe("The Knife", "knife");
        }

        [TestMethod]
        public void Input_system_Should_The_Space_System()
        {
            AssertShouldBe("The System", "system");
        }

        private string GetBandName(string noun)
        {
            var newBand = "The ";
            newBand += noun.Replace(noun[0], noun[0].ToString().ToUpper()[0]);
            return newBand;
        }
    }
}
