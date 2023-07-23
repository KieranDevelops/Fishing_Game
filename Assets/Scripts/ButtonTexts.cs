using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ButtonTexts : MonoBehaviour
{
    #region Text UI
    // Create text mesh pro ui reference points and assign smart names to use.

    public TextMeshProUGUI acceptText; // A text reference to the accept button.
    public TextMeshProUGUI releaseText; // A text reference to the release button.
    public TextMeshProUGUI catchFishText; // A text reference to the catch fish button.
    public int turnCountText; // an int to set the value of the turn.

    #endregion

    // Start is called before the first frame update
    void Start()
    {
        turnCountText = 0; // The starting value of the turns
        

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    #region text functions.
    public void AcceptText(string text) // A function to hold a string text
    {
        acceptText.GetComponent<TextMeshProUGUI>().text = "The fish caught was added to the aquarium"; // This is used to change the input text.
        Debug.Log("Press A to continue"); // Some text
    }

    public void ReleaseText(string text) // A function to hold a string text
    {
        releaseText.GetComponent<TextMeshProUGUI>().text = "Released the fish back into the ocean"; // This is used to change the input text.Text
        Debug.Log("Press X to continue"); // Some text
    }

    public void CatchFish(int text) // A function to hold a int text
    {

        turnCountText += 1; // This adds to the turn text.
        catchFishText.GetComponent<TextMeshProUGUI>().text = "Current Turn: " + turnCountText; // This is used to print the current turn.

    }
    #endregion
}
