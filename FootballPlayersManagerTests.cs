using Microsoft.VisualStudio.TestTools.UnitTesting;
using MandatoryAssignment4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MandatoryAssignment1;


namespace MandatoryAssignment4.Tests
{
    [TestClass()]
    public class FootballPlayersManagerTests
    {

        [TestMethod()]
        public void GetAllTest()
        {
            var manager = new FootballPlayersManager();
            List<FootballPlayer> footballPlayers = manager.GetAll();

            Assert.AreEqual(5,footballPlayers.Count);

            Assert.IsNotNull(footballPlayers);

            Assert.IsInstanceOfType(footballPlayers, typeof(List<FootballPlayer>));
        }

        [TestMethod()]
        public void GetByIdTest()
        {
            var manager = new FootballPlayersManager();
            FootballPlayer footballPlayer = manager.GetById(2);
            
            Assert.AreEqual("Flora", footballPlayer.Name);
        }

        [TestMethod()]
        public void AddTest()
        {
            var manager = new FootballPlayersManager();
            FootballPlayer newPlayer = new FootballPlayer {Id = 5, Name = "Polaris", Age = 26, ShirtNumber = 88};
            FootballPlayer addedPlayer = manager.Add(newPlayer);
            Assert.IsNotNull(addedPlayer);
            Assert.AreEqual(5, addedPlayer.Id);
        }



        

        [TestMethod()]
        public void UpdateTest()
        {
            var manager = new FootballPlayersManager();
            FootballPlayer updatePlayer = new FootballPlayer { Id = 4, Name = "Micky"};
            FootballPlayer updatedFootballPlayer = manager.Update(4, updatePlayer);
            Assert.AreEqual("Micky", updatedFootballPlayer.Name);
        }

        [TestMethod()]
        public void DeleteTest()
        {
            var manager = new FootballPlayersManager();
            FootballPlayer deletePlayer = manager.Delete(3);
            Assert.AreEqual(55, deletePlayer.ShirtNumber);
            Assert.AreEqual(4, manager.GetAll().Count);

        }
    }
}