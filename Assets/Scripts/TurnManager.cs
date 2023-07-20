using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TurnManager : MonoBehaviour
{
    public FishManager myAquarium; 
    public int turns = 0;
    public int endGame = 10;
    

    private List<Fish> aquariumList;


    // Start is called before the first frame update
    void Start()
    {
        List<Fish> aquarium = myAquarium.aquarium;
        aquariumList = aquarium;

    }

    // Update is called once per frame
    void Update()
    {

        // Set a button to start the game .
        // This should be something easy to use but not frequently pressed.
        // This will debug out a starting text.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Output game starting text
            Debug.Log("Welcome to FishManic, you get 10 turns to fill your aquarium. " +
                "If you get a fish that is double the size of another fish it will be eaten and you will lose your fish." +
                " enjoy and catch as many fish as you can");
            Debug.Log("Press 'F' to Start fishing");

        }

        // Has 'F' been pressed.
        // If yes then out put text you have cast a line
        if (Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log("You have cast your line into the calm ocean, GOOD LUCK :)");
            Debug.Log("Press 'R' to reel in your catch");

            // Call the finisgame funcion from the turnmanger script.
            // this will check if R has been pressed a certain amount of times and if it has not yet met 10.
            // it will continue the game.
            // if not it will print a text to finish game and total value of your aquarium.

            FinishGame();
            {

                for (int f = 0; f < aquariumList.Count; f++)
                {
                    Debug.Log(aquariumList[f].fishType + " " + aquariumList[f].fishLength + " cm" + " $" + aquariumList[f].fishPrice);

                }
            }


        }

        

    }

    public void FinishGame()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (turns < endGame)
                turns += 1;
            
        }
        else if (turns >= endGame)
        {
            Debug.Log("You have finished the game, good fishing!");
            Debug.Log("Now lets see what you have caught");
            for (int f = 0; f < aquariumList.Count; f++)
            {
                Debug.Log(aquariumList[f].fishType + " " + aquariumList[f].fishLength + " cm" + " $" + aquariumList[f].fishPrice);

            }

        }
    }
}
