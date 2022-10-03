using Microsoft.VisualStudio.TestTools.UnitTesting;
using MandatoryAssignment1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MandatoryAssignment1.Tests
{
    [TestClass()]
    public class FootballPlayerTests
    {
        FootballPlayer acceptablePlayer = new FootballPlayer{Id = 1, Name = "Barry", Age = 18, ShirtNumber = 55};
        FootballPlayer namePlayer = new FootballPlayer{Id = 2,Name = "A", Age = 30, ShirtNumber = 65};
        FootballPlayer agePlayer = new FootballPlayer{Id = 3, Name = "Lauren", Age = 0, ShirtNumber = 77};
        FootballPlayer shirtNumberPlayer = new FootballPlayer{Id = 4, Name = "Tiffany", Age = 25, ShirtNumber = 100};
        FootballPlayer shirtNumberPlayer2 = new FootballPlayer{Id = 5, Name = "Kevin", Age = 86, ShirtNumber = 0};


        [TestMethod()]
        public void ValidateToStringTest()
        {
            string str = acceptablePlayer.ToString();
            Assert.AreEqual("{Id=1, Name=Barry, Age=18, ShirtNumber=55}", str);
        }

        [TestMethod()]
        public void ValidateNameTest()
        {
            acceptablePlayer.ValidateName();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => namePlayer.ValidateName());
        }

        [TestMethod()]
        public void ValidateAgeTest()
        {
            acceptablePlayer.ValidateAge();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => agePlayer.ValidateAge());
        }

        [TestMethod()]
        public void ValidateShirtNumberTest()
        {
            acceptablePlayer.ValidateShirtNumber();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => shirtNumberPlayer.ValidateShirtNumber());
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => shirtNumberPlayer2.ValidateShirtNumber());
        }

        [TestMethod()]
        public void ValidateTest()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => namePlayer.Validate());
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => agePlayer.Validate());
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => shirtNumberPlayer.Validate());
        }
    }
}