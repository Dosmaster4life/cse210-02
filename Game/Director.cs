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
                displayedCard.createCardNumber();
                hiddenCard.createCardNumber();

               player.makeGuess(getInput(displayedCard.currentCard));
                printConsole(hiddenCard.currentCard);
               if(displayedCard.currentCard < hiddenCard.currentCard) {
                   if(player.highOrLow) {
                       player.increasePoints();
                   }else {
                       player.decreasePoints();
                   }
               }else if(displayedCard.currentCard > hiddenCard.currentCard) {
                        if(!player.highOrLow) {
                       player.increasePoints();
                   }else {
                       player.decreasePoints();
                   }
               }else {
                   Console.WriteLine("You tied"); // make this message fancy later

               }
                printScore(player.lifePoints);
            }
        }
        public string getInput(int displayedNumber)
        {
            Console.Write("The card is " + displayedNumber + "\n Higher or Lower? [h/l]");
            string getResponse = Console.ReadLine();
            if(getResponse == null) {
                getResponse = "";
            }
            return getResponse;
        }

        public void printConsole (int currentCardNumber)
        {
            Console.Write($"Next card was: {currentCardNumber}\n");
        }

        public void printScore (int score)
        {
            Console.WriteLine($"Your current score is: {score}");
        }
    }
}