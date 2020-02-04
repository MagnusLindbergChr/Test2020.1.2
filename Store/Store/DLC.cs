using System;

namespace Store
{
    public class DLC
    {

        string title;
        string description;
        string genre;
        string rating;
        Game game;
        double price;

        public DLC(string dTitle, string dRating, string dGenre, double dPrice Game dGame)
        {
            title = dTitle;
            rating = dRating;
            genre = dGenre;
            price = dPrice;
            Game = dGame;
        }
    }
}
