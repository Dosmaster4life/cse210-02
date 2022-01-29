using System;
using System.Collections.Generic;

namespace Game
{

    public class Director {
        bool playingNow = true;
        bool highOrLow = false;
               public void StartGame()
        {
            while (playingNow) // Call methods and functions from here, infinite loop until PlayNow is false;
            {
               getInput();
               Player.makeGuess(getResonse);

            }
        }
        public void getInput() {
            Console.Write("The card is " + "Function to get card here" + "\n Higher or Lower? [h/l]");
            string getResponse = Console.ReadLine();
            if(getResponse == "e") {
                playingNow = false;
            
            }else if(getResponse == "h") {
                highOrLow = true;
            }else if(getResponse == "l") {
                highOrLow = false;
            }

          
           
        }
    }
}