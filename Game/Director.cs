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
                displayedCard.CreateCardNumber();
                hiddenCard.CreateCardNumber();

               player.makeGuess(getInput(displayedCard.currentCard));

               if(displayedCard.currentCard > hiddenCard.currentCard) {
                   if(player.highOrLow) {
                       player.increasePoints();
                   }else {
                       player.decreasePoints();
                   }
               }else if(displayedCard.currentCard < hiddenCard.currentCard) {
                        if(!player.highOrLow) {
                       player.increasePoints();
                   }else {
                       player.decreasePoints();
                   }
               }else {
                   

               }

            }
        }
        public static string getInput(int displayedNumber) {
            Console.Write("The card is " + displayedNumber + "\n Higher or Lower? [h/l]");
            string getResponse = Console.ReadLine();
            if(getResponse != "e" && getResponse != "h" && getResponse != "l") {
                System.Console.WriteLine("Type 'h' if you want to guess High \nor 'l' for Low \nand 'e' to end the game.\n");
                getInput(displayedNumber);
                getResponse = "";
            }
            return getResponse;
        }
    }
}