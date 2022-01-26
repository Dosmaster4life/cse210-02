using System;
using System.Collections.Generic;

namespace Game
{

    public class Director {
        bool playingNow = true;
         public void StartGame()
        {
            while (playingNow) // Call methods and functions from here, infinite loop until PlayNow is false;
            {
               getInput();

            }
        }
        public void getInput() {
            Console.Write("The card is " + "Function to get card here" + "\n Higher or Lower? [h/l]");
            string getResponse = Console.ReadLine();
           if(getResponse == "h") {

           } else if(getResponse == "l") {

           }else { // if user chooses somthing other than h or l

           }
        }
    }
}