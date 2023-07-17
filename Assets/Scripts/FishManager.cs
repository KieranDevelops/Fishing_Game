using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using Unity.VisualScripting;

public class FishManager : MonoBehaviour
{
    #region My Access scripts and lists
    public Fish currentFish;
    public List<Fish> allFish = new List<Fish>(); // creating a List for 
    public List<Fish> aquarium = new List<Fish>();
    #endregion

    public bool isCurrentFish = false;

    #region This call for all fish to access the Fish script and add it to the list
    // Start is called before the first frame update
    void Start()
    {
        
        allFish = FindObjectsOfType<Fish>().ToList();
        //currentFish = allFish[0];
        //allFish.Remove(currentFish);
        //currentFish.FishSetUp();
    }

    #endregion

    #region All my updates contaning Inputs and add/removing fish
    // Update is called once per frame
    void Update()
    {
        // only do this if current fish is null
        if (currentFish == null)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                Debug.Log("Press 'R' to catch a fish");
                // grab a random fish and assign to current fish
                //caughtFish.FishSetUp();
                //currentFish = caughtFish;
                currentFish = allFish[0];
                allFish.Remove(currentFish);
                currentFish.FishSetUp();
                Debug.Log(currentFish.fishType + " " + currentFish.fishLength + " " + currentFish.fishPrice);
            }
        }


        // check if current fish is not null
        if (currentFish != null)
        {


            // if so A to keep X to throw back.
            if (Input.GetKeyDown(KeyCode.A))
            {
                //Keep Fish
                Debug.Log("You put the fish into your aquarium");
                DespawnFish(currentFish);
                // Is the fish bigger than any fish in your aquarium?
                // If so compare the lengths by multiply the aquarium fish by and comparing it with the current fish
                // then remove the smaller as it has been eaten.
                for ( int i = 0; i < aquarium.Count; i++)
                {
                    if ((aquarium[i].fishLength * 2) < currentFish.fishLength)
                    {
                        aquarium.RemoveAt(i);
                        Debug.Log("One of your fish were to small to live in harmony with the fish you put in, it got eaten");
                    }

                }
                

            }
            if (Input.GetKeyDown(KeyCode.X))
            {
                //Release Fish
                SpawnFish(currentFish);
            }
        }



    }
    #endregion

    #region A new function I created to call when adding and removing fish
    // Create a new function to spawn a fish and add it to aquarium List
    // This should call the Fish Setup funtion to randomly generate what fish it is.

    public void SpawnFish(Fish fish)
    {
        allFish.Add(fish);
        currentFish = null;
        Debug.Log("This fish is in your aquarium " + currentFish);

    }

    public void DespawnFish(Fish fish)
    {
        allFish.Remove(fish);
        currentFish = null;
        aquarium.Add(fish);
    }
    #endregion
}
