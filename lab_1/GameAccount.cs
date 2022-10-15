﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    public class GameAccount
    {
        public string UserName { get; set; }
        public int CurrentRating
        {
            get
            {
                int rating = 600;

                foreach (var game in allGames)
                {
                    rating += game.Rating;
                }

                return rating;
            }
        }
        public int GamesCount
        {
            get
            {
                return allGames.Count;
            }
        }

        private List<GameRecord> allGames = new List<GameRecord>();
        public GameAccount(string userName)
        {
            UserName = userName;
        }

        public void WinGame(GameAccount Opponent, int rating, int idOfTheMatch)
        {
            if (rating <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(rating), "Rating should be positive");
            }
            GameRecord game = new GameRecord(this, Opponent, rating, idOfTheMatch, "Win");
            allGames.Add(game);
        }

        public void LoseGame(GameAccount Opponent, int rating, int idOfTheMatch)
        {
            if (rating <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(rating), "Rating should be positive");
            }
            if (CurrentRating - rating <=0)
            {
                throw new InvalidOperationException("A Rating is bigger that a rating of the player");
            }
            GameRecord game = new GameRecord(this, Opponent, -rating, idOfTheMatch,"Lose");
            allGames.Add(game);
        }

        public string GetStats()
        {
            var report = new System.Text.StringBuilder();
            report.AppendLine("Against\tResult\tRating\tId");
            foreach (var game in allGames)
            {
                report.AppendLine($"{game.Opponent.UserName}\t{game.Result}\t{game.Rating}\t{game.GameId}");
            }
            return report.ToString();
        }
    }
}