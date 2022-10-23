using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    public class GameRecord
    {
        public int GameId { get; }
        public GameAccount Player { get; }
        public GameAccount Opponent { get; }
        public int Rating { get; }
        public string Result { get; }
        public string GameType { get; }

        public GameRecord(int id, GameAccount player, GameAccount opponent, int rating, string result, string gameType)
        {
            GameId = id;
            GameType = gameType;
            Player = player;
            Opponent = opponent;
            Rating = rating;
            Result = result;
        }
    }
}