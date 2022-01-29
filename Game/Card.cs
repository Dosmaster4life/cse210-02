
using System;
using System.Collections.Generic;

namespace Game;
public class Card {

    // create methed called "createCardNumber" that will create a number for the varible called 'curenntCard' this will also move the number that was in
    // curenntCard to  

    Random random = new Random();
    
    // create methed called "createCardNumber" that will create a number for the varible called 'currentCard' this will also move the number that was in 
    public int currentCard = 0;
    public void CreateCardNumber ()
    {
        int currentCard = random.Next(1,14);
        Console.Write($"Card is: {currentCard}");
    }
}

