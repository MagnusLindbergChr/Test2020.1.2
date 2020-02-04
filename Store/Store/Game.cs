using System;
using System.Collections.Generic;

namespace Store
{
    public class Game
    {

        string title;
        string description;
        string[] genre;
        int metaCritic;
        string systemRequirements;
        List<DLC> dlcs;
        double price;

        public Game(string gTitle, string gDescription, double gPrice)
        {
            title = gTitle;
            price = gPrice;
            description = gDescription;
        }
    }
}
