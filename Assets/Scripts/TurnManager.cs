using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnManager : MonoBehaviour
{
   

    // Start is called before the first frame update
    void Start()
    {


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

            // Has 'R' been pressed
            // Yes it has
            // Out you have caught a fish and the fish stats
            // Ask if you would like to keep it or release it

            
        }
    }
}
