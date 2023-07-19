using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour
{
    #region Varibles to hold fish values
    // Creates some varibles to assign some values to the fish later
    // This shoould contain what type of fish, its length and the price of the frish
    // The price will be determined by multipling the length of the fish by 2
    public string fishType;
    public float fishLength;
    public int fishPrice;
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
    public void FishSetUp()
    {
        fishLength = Random.Range(0f, 15f);

        if (fishLength > 10)
        {
            fishType = "Big Fish";
        }
        else if (fishLength < 10 && fishLength > 5)
        {
            fishType = "Medium Fish";
        }
        else
        {
            fishType = "Small Fish";
        }
        
        fishPrice = (int)fishLength * 2;
    }
    #endregion
}
