using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    public abstract class Game
    {
        protected static int Id = 0;

        protected Random random = new Random();

        public abstract string GameType { get; }

        protected abstract int GenerateRating();



        public virtual void PlayGame(GameAccount firstPlayer, GameAccount secondPlayer)
        {
            int rating = this.GenerateRating();
            int winnerSide = random.Next(1, 3);
            if (winnerSide == 1)
            {
                firstPlayer.WinGame(secondPlayer, rating, Id, this.GameType);
                secondPlayer.LoseGame(firstPlayer, rating, Id, this.GameType);
            }
            else
            {
                firstPlayer.LoseGame(secondPlayer, rating, Id, this.GameType);
                secondPlayer.WinGame(firstPlayer, rating, Id, this.GameType);
            }
            Id++;
        }
    }

    public class BasicGame : Game
    {
        public override string GameType
        {
            get
            {
                return "Basic";
            }
        }

        protected override int GenerateRating()
        {
            return 0;
        }
    }
    
    public class RankedGame : Game
    {
        public override string GameType
        {
            get
            {
                return "Ranked";
            }
        }

        protected override int GenerateRating()
        {
            return random.Next(20, 26);
        }
    }

    public class SafeGame : RankedGame
    {
        public override string GameType
        {
            get
            {
                return "Safe";
            }
        }

        public override void PlayGame(GameAccount firstPlayer, GameAccount secondPlayer)
        {
            int rating = this.GenerateRating();
            int winnerSide = random.Next(1, 3);
            if (winnerSide == 1)
            {
                firstPlayer.WinGame(secondPlayer, rating, Id, this.GameType);
                secondPlayer.LoseGame(firstPlayer, 0, Id, this.GameType);
            }
            else
            {
                firstPlayer.LoseGame(secondPlayer, 0, Id, this.GameType);
                secondPlayer.WinGame(firstPlayer, rating, Id, this.GameType);
            }
            Id++;
        }
    }
}
