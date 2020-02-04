using System;

namespace Store
{
    public class Store
    {

        Showcase showcase;

        // Buying things
        // Seeing what is for sale

        public Store()
        {
            showcase = new Showcase(5);
            Game g1 = new Game("Braid", "Timywimey puzzle game", 10);
            // We need to add games to the showcase
        }
    }
}
