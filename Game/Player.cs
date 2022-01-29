
using System;
using System.Collections.Generic;

namespace Game;
public class Player {
// create methed called "LifePointsCounter" that will output an integer type varible called 'lifePoints' 

// create methed called "MakeGuess" that will pull the user's input and store it in the varible called 'highLow'

// create methed called "checkAnswer" that will take 'highLow' and 'curenntCard' to see if the user guess is high or low. 


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
public int lifePointsCounter() {
    return this.lifePoints;
}
public void decreasePoints() {
    lifePoints -=  75;
}
public void increasePoints() {
    lifePoints += 100;
}


}