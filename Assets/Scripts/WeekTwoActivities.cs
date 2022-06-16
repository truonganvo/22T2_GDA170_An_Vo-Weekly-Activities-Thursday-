using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AnVo
{
    public class WeekTwoActivities : MonoBehaviour
    {
        // Variables
        private string favouriteGame = "Arma 3";
        private int hoursPlayed = 110;
        private float gamePrice = 25.5f;

        public float myFloat;
        public int myInt; 

        // Start is called before the first frame update
        void Start()
        {
            Debug.Log("My favourite game is " + favouriteGame + 
                ". I have played it for " + hoursPlayed + 
                " hours, and it cost me $" + gamePrice + 
                ". Therefore my value dollar per hour is $" + gamePrice / hoursPlayed + ".");

            myFloat = Random.Range(0f, 10f); // It return a random decimal number. Must include f at the end at the min and the max so that the number doesn't return as a whole.
            myInt = Random.Range(0, 10);


          
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}

