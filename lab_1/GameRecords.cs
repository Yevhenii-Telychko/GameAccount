using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    public class GameRecord
    {
        public GameAccount Player { get; }
        public GameAccount Opponent { get; }
        public int Rating { get; }
        public int GameId { get; }
        public string Result { get; }

        public GameRecord(GameAccount player, GameAccount opponent, int rating, int id,string result)
        {
            GameId = id;
            Player = player;
            Opponent = opponent;
            Rating = rating;
            Result = result;

        }
    }
}