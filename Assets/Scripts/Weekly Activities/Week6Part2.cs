using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Week6Part2 : MonoBehaviour
{
    public string[] favouriteThings = { "Apple", "Ant", "And", "Ah"}; //Array
    List<string> favouriteThings2 = new List<string>(); //List

    //Timer - Every 2 second 
    private float timerSpeed = 2f; 
    private float elapsed;
    //Timer - Once 5 second elapse
    private float timerCountdown = 5f;


    void Start()
    {
        //Array
        for (int i = 0; i < favouriteThings.Length; i++)
        {
            Debug.Log("Favourite Things in ARRAY: " + favouriteThings[i]);
        }

        //List
        favouriteThings2.Add("Bacon");
        favouriteThings2.Add("Beat");
        favouriteThings2.Add("Ballon");
        favouriteThings2.Add("Bird");

        for (int y = 0; y < favouriteThings2.Count; y++)
        {
            Debug.Log("Favourite Things in List: " + favouriteThings2[y]);
        }

    }

    // Update is called once per frame
    void Update()
    {       
        elapsed += Time.deltaTime; 
        //Wait for 5 second please...
        if (elapsed >= timerCountdown)
        {
            Debug.Log("5 SECOND PASS ALREADY MATE");
        }

        //Every 2 Second i guess

        if (elapsed >= timerSpeed)
        {
            Debug.Log("Every 2 Second.");
            elapsed = 0f;
        }
    }
}
