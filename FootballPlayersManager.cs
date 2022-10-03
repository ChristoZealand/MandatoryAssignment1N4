using System.Reflection;
using MandatoryAssignment1;

namespace MandatoryAssignment4
{
    public class FootballPlayersManager
    {
        private static int nextid = 1;

        private static readonly List<FootballPlayer> footballPlayers = new List<FootballPlayer>
        {
            new FootballPlayer{Id = nextid++, Name = "Kennedy", Age = 25, ShirtNumber = 78},
            new FootballPlayer{Id = nextid++, Name = "Flora", Age = 29, ShirtNumber = 23},
            new FootballPlayer{Id = nextid++, Name = "Kevin", Age = 34, ShirtNumber = 55},
            new FootballPlayer{Id = nextid++, Name = "Mick", Age = 19, ShirtNumber = 99}
        };

        public FootballPlayersManager()
        {
            
        }

        // GetAll, GetById, Add, Update and Delete

        public List<FootballPlayer> GetAll()
        {
            return new List<FootballPlayer>(footballPlayers);
        }

        public FootballPlayer GetById(int? id)
        {
            return footballPlayers.Find(footballplayer => footballplayer.Id == id);
        }

        public FootballPlayer Add(FootballPlayer newPlayer)
        {
            newPlayer.Id = nextid++;
            footballPlayers.Add(newPlayer);
            return newPlayer;
        }

        public FootballPlayer Delete(int id)
        {
            FootballPlayer deletePlayer = footballPlayers.Find(footballplayer => footballplayer.Id == id);
            if (deletePlayer == null) return null;
            footballPlayers.Remove(deletePlayer);
            return deletePlayer;
        }

        public FootballPlayer Update(int id, FootballPlayer update)
        {
            FootballPlayer updatePlayer = footballPlayers.Find(footballplayer => footballplayer.Id == id);
            if (updatePlayer == null) return null;
            updatePlayer.Id = update.Id;
            updatePlayer.Name = update.Name;
            updatePlayer.Age = update.Age;
            updatePlayer.ShirtNumber = update.ShirtNumber;

            return updatePlayer;
        }
    }
}
