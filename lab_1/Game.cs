using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    public class Game
    {
        public int Id { get; set; }

        public void PlayGame(GameAccount firstPlayer, GameAccount secondPlayer)
        {
            Random random = new Random();
            int rating = random.Next(20, 26);
            int winnerSide = random.Next(1, 3);
            if (winnerSide == 1)
            {
                firstPlayer.WinGame(secondPlayer, rating, Id);
                secondPlayer.LoseGame(firstPlayer, rating, Id);
            }
            else
            {
                firstPlayer.LoseGame(secondPlayer, rating, Id);
                secondPlayer.WinGame(firstPlayer, rating, Id);
            }
            Id++;
        }
    }
}
