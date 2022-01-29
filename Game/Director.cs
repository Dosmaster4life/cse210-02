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
               if (playingNow){

               
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
               }else{
                   System.Console.WriteLine($"Game Over! \n Your final score was: {player.lifePoints}");
                   
               }
            }
        }
        public string getInput(int displayedNumber)
        {
            string getResponse = "";
            Console.Write("The card is " + displayedNumber + "\nHigher or Lower? [h/l] \n(press 'e' at anytime to exit)");
            try {
            getResponse = Console.ReadLine();
            }
            catch(Exception e) {
               getResponse = "";
            }
            
            if(getResponse != "e" && getResponse != "h" && getResponse != "l") {
                System.Console.WriteLine("Type 'h' if you want to guess High \nor 'l' for Low \nand 'e' to end the game.\n");
                getInput(displayedNumber);
                getResponse = "";
            }
            return getResponse;
        }

        public void printConsole (int currentCardNumber)
        {
            Console.Write($"\nNext card was: {currentCardNumber}\n");
        }

        public void printScore (int score)
        {
            Console.WriteLine($"Your current score is: {score}\n");
        }
    }
}