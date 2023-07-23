using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class TurnManager : MonoBehaviour
{
    #region An area to hold some variables and cross script references.
    // Create some variables to hold values for a turn and the max number of turns.
    // The max number of turns is 10.

    public int turns = 0; // An int to hold my turns.
    public int endGame = 10; // An int to hold the max number of turns.
    public int totalAquariumValue = 0; // An int to hold the the value of the aquarium.

    // Access other scripts and call the required material to use in this script.

    public FishManager myAquarium; // A cross script rference to fishManager to hold a vlaue that can access a list later.
    private List<Fish> aquariumList; // A private script refernece to a List of fish assigned aquarium list to access the aquraium list in fish manager.

    public int numberOfFish;
    [SerializeField] private GameObject objectToSpawn;
    [SerializeField] Transform parent;
    #endregion

    #region A start function to hold my access into the aquarium list and instantiations
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numberOfFish; i++)
        {
            Vector3 position = new Vector3(Random.Range(10f, 820f), Random.Range(15f, 420f), Random.Range(0f, 0f));
            Instantiate(objectToSpawn, position, Quaternion.identity, parent);
        }


        // Create a refernce point that calls the aquraium list to the turn manager.

        List<Fish> tempAquarium = myAquarium.aquarium;// This calls the aquarium list and allows access through myAquarium.
        aquariumList = tempAquarium; // This creates a variable that will be used  to acces the list later.



    }
    #endregion

    #region My Inputs Functions
    // Update is called once per frame
    void Update()
    {
       
        // Set a button to start the game .
        // This should be something easy to use but not frequently pressed.
        // This will debug out a starting text.

        if (Input.GetKeyDown(KeyCode.Space)) // This will notify unity that space has been pressed down. 
        {
            // Output game starting text
            Debug.Log("Welcome to FishManic, you get 10 turns to fill your aquarium. " +
                "If you get a fish that is double the size of another fish it will be eaten and you will lose your fish." +
                " enjoy and catch as many fish as you can"); // Some starting text.
            Debug.Log("Press 'F' to Start fishing"); // Some prompt for next step.
            
        }

        // Has 'F' been pressed.
        // If yes then out put text you have cast a line
        if (Input.GetKeyDown(KeyCode.F)) // This will notify unity that F has been pressed down. 
        {
            Debug.Log("You have cast your line into the calm ocean, GOOD LUCK :)"); // Some text.
            Debug.Log("Press 'R' to reel in your catch"); // Some prompt for next step.

            // Call the finisgame funcion from the turnmanger script.
            // this will check if R has been pressed a certain amount of times and if it has not yet met 10.
            // it will continue the game.
            // if not it will print a text to finish game and total value of your aquarium.

           

        }

        

    }

    #endregion

    #region A function to Finish the game

    // Create a fucntion that will calculate the turns and add to it.
    // This should compare turns and endGame to determine wether it needs to add to turns.
    // If turns is greater or equal to endGame it should print out the some finish text and a For Loop.
    public void FinishGame() // This is a function to check if the game is finished.
    {

        

        if (turns < endGame) // This check if turns is less than endGame.
        {
            turns += 1; // This adds 1 value to turns.
        }

        if (turns == endGame) // This checks if turns is equal or greater than endGame.
        {
            Debug.Log("You have finished the game, good fishing!"); // Some finish game text.
            Debug.Log("Now lets see what you have caught"); // Some text.
            for (int f = 0; f < aquariumList.Count; f++) // A for loop to loop through aquarium and display the fish in the aquarium.
            {
                Debug.Log(aquariumList[f].fishType + " " + aquariumList[f].fishLength + " cm" + " $" + aquariumList[f].fishPrice);
                totalAquariumValue += aquariumList[f].fishPrice;
                Debug.Log("The total of your aquarium is " + "$" + totalAquariumValue);

            }

        }
        
    }
    #endregion

   
}
