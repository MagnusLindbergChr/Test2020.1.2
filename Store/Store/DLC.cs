using System;

namespace Store
{
    public class DLC
    {

        string title;
        string description;
        string genre;
        string rating;
        Game parentGame;
        double price;

        public DLC(string title, double price, string description)
        {
            this.title = title;
            this.price = price;
            this.description = description;
        }
    }
}
