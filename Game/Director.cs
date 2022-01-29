using System;
using System.Collections.Generic;

namespace Game
{

    public class Director {
        public static bool playingNow = true;
        string response = "";
        
               public void StartGame()
        {
            Player player = new Player();
            while (playingNow) // Call methods and functions from here, infinite loop until PlayNow is false;
            {
                Card displayedCard = new Card();
                Card hiddenCard = new Card();

               player.makeGuess(getInput(1));

            }
        }
        public string getInput(int displayedNumber) {
            Console.Write("The card is " + displayedNumber + "\n Higher or Lower? [h/l]");
            string getResponse = Console.ReadLine();
            if(getResponse == null) {
                getResponse = "";
            }
            return getResponse;
        }
    }
}