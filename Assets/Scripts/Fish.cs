using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour
{

    public string fishType;
    public float fishLength;
    public int fishPrice;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
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
}
