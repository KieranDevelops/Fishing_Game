using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class FishManager : MonoBehaviour
{
    public Fish fishOne;
    public Fish fishTwo;
    public Fish fishThree;
    public Fish fishFour;
    public Fish fishFive;
    public Fish fishSix;
    public Fish fishSeven;
    public Fish fishEight;
    public Fish fishNine;
    public Fish fishTen;

    public List<Fish> allFish = new List<Fish>();
    public List<Fish> myFishAmount = new List<Fish>();
    


    // Start is called before the first frame update
    void Start()
    {
        
        allFish = FindObjectsOfType<Fish>().ToList();
        fishOne.FishSetUp();
        fishTwo.FishSetUp();
        fishThree.FishSetUp();
        fishFour.FishSetUp();
        fishFive.FishSetUp();
        fishSix.FishSetUp();
        fishSeven.FishSetUp();
        fishEight.FishSetUp();
        fishNine.FishSetUp();
        fishTen.FishSetUp();
        myFishAmount = allFish;

           



        
    }


// Update is called once per frame
void Update()
    {

    }

    public void SpawnFish(Fish fish)
    {
        myFishAmount.Add(fish);
        Debug.Log("A fish is the water, catch it before its to late; " + fish.fishType);

    }

    public void DespawnFish(Fish fish)
    {
        myFishAmount.Remove(fish);

    }

}
