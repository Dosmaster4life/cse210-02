using System;
using System.Collections.Generic;

namespace Game;
public class Player {

public int lifePoints;
public bool highOrLow = false;
public void makeGuess(string getResponse) {
    if(getResponse == "e") {
                Director.playingNow = false;
            }else if(getResponse == "h") {
                highOrLow = true;
            }else if(getResponse == "l") {
                highOrLow = false;
            }

}

}