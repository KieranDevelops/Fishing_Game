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

    public TurnManager finishTheGame;
    #endregion

    public bool isCurrentFish = false;
    public int totalAquariumValue = 0;

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
                
                // grab a random fish and assign to current fish
                //caughtFish.FishSetUp();
                //currentFish = caughtFish;
                currentFish = allFish[0];
                allFish.Remove(currentFish);
                currentFish.FishSetUp();
                Debug.Log("You Caught a " + currentFish.fishType + " " + currentFish.fishLength + " cm" + " $" + currentFish.fishPrice + " did you want to Keep it (A) or throw it back in (X)?");

                
            }
        }


        // check if current fish is not null
        if (currentFish != null)
        {


            // if so A to keep X to throw back.
            if (Input.GetKeyDown(KeyCode.A))
            {
                // Keep Fish by pressing a button or the UI text
                // Is the fish bigger than any fish in your aquarium?
                // If so compare the lengths by multiply the aquarium fish by and comparing it with the current fish
                // then remove the smaller as it has been eaten.
                Debug.Log("You put the fish into your aquarium.");

                for (int i = 0; i < aquarium.Count; i++)
                {
                    if ((aquarium[i].fishLength * 2) < currentFish.fishLength)
                    {
                        aquarium.RemoveAt(i);
                        Debug.Log("One of your fish were to small to live in harmony with the fish you put in, it got eaten");
                    }

                }

                // Despawn the fish out the allFish list
                // This will call the function DespawnFish and add it to our aquarium.

                DespawnFish(currentFish);
                
            }

            
            

            if (Input.GetKeyDown(KeyCode.X))
            {
                // Release Fish by pressing a button or the UI button
                // This should call the SpawnFish function and add the fish back to the allFish list.
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
