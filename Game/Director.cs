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
               player.makeGuess(getInput());

            }
        }
        public string getInput() {
            Console.Write("The card is " + "Function to get card here" + "\n Higher or Lower? [h/l]");
            string getResponse = Console.ReadLine();
            return getResponse;
        }
    }
}