using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine.UI;

public class FishManager : MonoBehaviour
{
    #region My Access scripts and lists
    // Create some cross script references to acces the Fish script
    // Create 2 lists to and name them allFish (sea) and aquarium.
    // Create a single varible that is a reference to the fish script to be used later.

    public Fish currentFish; // A reference to access the fish script.
    public List<Fish> allFish = new List<Fish>(); // creating a List for all the fish in the sea.
    public List<Fish> aquarium = new List<Fish>(); // creating a List to hold all the fish in the aquarium.
   
    // Create a reference to the TurnManager to call the finish the game function.

    public TurnManager finishTheGame; // A reference to access the TurnManager script.

    #endregion

    #region Some varaibles
    // Create a bool to check if a condition is false.
    // This is used for backup, doesn't need to be used.
    public bool isCurrentFish = false; // A bool to use to see if a condition is false.
    
    
    #endregion

    #region Fish Objects
    // Start is called before the first frame update
    void Start()
    {
     // Create a reference to the objects in the hierachy.
     // This should also use the ToList() function to add it the allFish list.
     // Use system.Linq to be able to utilise ToList()

        allFish = FindObjectsOfType<Fish>().ToList(); // referencing all fish objects to the allfish List.
        
        

        #region Extra
        // Evidence of trying to figure out how Lists worked and where to correctly use the code.

        //currentFish = allFish[0];
        //allFish.Remove(currentFish);
        //currentFish.FishSetUp();
        #endregion
    }
    

    #endregion

    #region All my updates contaning Inputs and add/removing fish

    // Update is called once per frame
    void Update()
    {

        // Check to see if currentFish is equal to null.
        // This should only do the following if currentFish is null.
        if (currentFish == null) // checking if currentFish is null.
        {
            if (Input.GetKeyDown(KeyCode.R)) // This will notify unity that R has been pressed down. 
            {

                // Grab a random fish and assign to current fish
                #region Extra
                // Some more evidence of me trying to figure out how to assign value to the fish and add them to the List.
                // CaughtFish.FishSetUp();
                // currentFish = caughtFish;
                #endregion

                currentFish = allFish[0]; // assign currentFish to the element position 0 in allFish
                allFish.Remove(currentFish); // This will remove the currentFish out of the List and technically be on the fishing line.
                currentFish.FishSetUp(); // This will assign all the data to the fish that has been caught by using the FishSetUp() function.
                Debug.Log("You Caught a " + currentFish.fishType + " " + currentFish.fishLength + " cm" + " $" + currentFish.fishPrice + " did you want to Keep it (A) or throw it back in (X)?"); // Print out what you have caught and prompt next step.

                /*
                 * I have placed this here as it was not calling correctly in the turn manager as this Input R was prioritising.
                */
                finishTheGame.FinishGame(); // This calls the FinishGame() function after R has been pressed.
            }

        }

        // check if current fish is not null
        if (currentFish != null) // This check is current fish is not null andis holding a value.
        {

            // if so A to keep X to throw back.
            if (Input.GetKeyDown(KeyCode.A)) // This will notify unity that A has been pressed down. 
            {
                // Keep Fish by pressing a button or the UI text
                // Is the fish bigger than any fish in your aquarium?
                // If so compare the lengths by multiply the aquarium fish by and comparing it with the current fish
                // then remove the smaller as it has been eaten.
                Debug.Log("You put the fish into your aquarium."); // Some text

                for (int i = 0; i < aquarium.Count; i++) // This is a for Loop to loop through aquarium list.
                {
                    if ((aquarium[i].fishLength * 2) < currentFish.fishLength) // This will compare the recently added fish to the exisiting fish in the List and check size difference.
                    {
                        aquarium.RemoveAt(i); // if the fish is doubel the size, the smaller fish is removed from the aquarium.
                        Debug.Log("One of your fish were to small to live in harmony with the fish you put in, it got eaten"); // Some text.
                    }
                }

                // Despawn the fish out the allFish list
                // This will call the function DespawnFish and add it to our aquarium.

                DespawnFish(currentFish); // This will call the DesapwnFish() function.
                
            }


            if (Input.GetKeyDown(KeyCode.X)) // This will notify unity that A has been pressed down. 
            {
                // Release Fish by pressing a button or the UI button
                // This should call the SpawnFish function and add the fish back to the allFish list.

                SpawnFish(currentFish); // This will call the SpawnFish() setup.
                Debug.Log("Released fish back into the water, Press R to keep fishing");
            }
        }

    }
    #endregion

    #region A new function I created to call when adding and removing fish
    // Create a new function to spawn a fish and add it to aquarium List
    // This should call the Fish Setup funtion to randomly generate what fish it is.

    public void SpawnFish(Fish fish) // A function to spawn fish.
    {
        allFish.Add(fish); // This will add a fish to allFish list.
        currentFish = null; // This will set the currentFish to null.

    }

    public void DespawnFish(Fish fish) // A function to despawn fish.
    {
        allFish.Remove(fish); // This will remove fish from allFish List.
        currentFish = null; // This will reset the currentFish to null.
        aquarium.Add(fish); // This will add the fish to the Aquraium
        

    }
    #endregion

    
}
