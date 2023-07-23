using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour
{
    #region Varibles to hold fish values
    // Creates some varibles to assign some values to the fish later.
    // This shoould contain what type of fish, its length and the price of the fish.
    // The price will be determined by multipling the length of the fish by 2.

    public string fishType; // This is a string to hold my fish type for later.
    public float fishLength; // This is a float to hold my fish length.
    public int fishPrice; // This is an int to hold the whole price of the fish.
    #endregion

    #region A start function to use in this script
    // Start is called before the first frame update
    void Start()
    {
        // Use this if needed later
    }
    #endregion

    #region A update function to use in this script
    // Update is called once per frame
    void Update()
    {
        
        // Use this later if needed.
    }
    #endregion

    #region Setting up fish
    // Set up a funtion to call on to set up different fish
    // This should consist of fish lenght, type and price
    // the fish type will be determined from the random range in fish length with if statements.
    public void FishSetUp() // This is a Function to set up my fish.
    {
        fishLength = Random.Range(0f, 15f); // This is to set a random value to the fish when called assigning the value between 0 and 15.

        if (fishLength > 10) // This is a question to ask if the fish bigger than 10 so it can be assigned a name.
        {
            fishType = "Big Fish"; // A fish  type.
        }
        else if (fishLength < 10 && fishLength > 5) // This is a question to ask if the fish less than 10 and greater than5 so it can be assigned a name.
        {
            fishType = "Medium Fish"; // A fish  type.
        }
        else // This is to assign anything below the already assigned ranges will be given a name.
        {
            fishType = "Small Fish"; // A fish  type.
        }
        
        fishPrice = (int)fishLength * 2; // Calculating the cost of a fish by multiplying the length by 2.
    }
    #endregion
}
