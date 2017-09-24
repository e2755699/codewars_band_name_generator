using System;
using System.Linq;
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

        [TestMethod]
        public void Input_tart_ShouldRetrun_Trartart()
        {
            AssertShouldBe("Tartart", "tart");
        }

        private string GetBandName(string noun)
        {
            if (IsFristAndLastLetterSame(noun))
            {
                return ChangeFirstLetterToUpper(noun.Replace(noun, noun + noun).Remove(noun.Length, 1));
            }
            
            return "The " + ChangeFirstLetterToUpper(noun);
        }

        private static bool IsFristAndLastLetterSame(string noun)
        {
            return noun[0] == noun[noun.Length - 1];
        }

        private string ChangeFirstLetterToUpper(string noun)
        {
            var nounOfCharArray = noun.ToCharArray();
            nounOfCharArray[0] = Char.ToUpper(nounOfCharArray[0]);
            return String.Concat(nounOfCharArray);
        }
    }
}
