using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Week4Activities : MonoBehaviour

   
{
    // Start is called before the first frame update
    void Start()
    {
        int currentYear = Random.Range(1990, 9999);
        Debug.Log("Year: " + currentYear);

        if (currentYear % 400 == 0)
        {
            Debug.Log("This is a leap year");
        }
        else
        {
            Debug.Log("Not a leap year.");
        }

        float Fahrenheit = Random.Range(-100F, 200F);
        float Celcius;
        {
            Celcius = (Fahrenheit - 32) * 5 / 9;
        }
        Debug.Log("If Fahrenheit = " + Fahrenheit + "F" + ".Then Celcius = " + Celcius + "C.");


        if (Celcius < 0)
        {
            Debug.Log("Freezing Weather.");
        }
        else if (Celcius > 0 && Celcius < 10)
        {
            Debug.Log("Very Cold Weather.");
        }
        else if ((Celcius > 10 && Celcius < 20) || Celcius < 13)
        {
            Debug.Log("It's a bit cool.");
        }
        else if (Celcius == 14)
        {
            Debug.Log("It's a bit cool mate.");
        }
        else if (Celcius > 13 && Celcius < 20)
        {
            Debug.Log("It's cold Weather.");
        }
        else if (Celcius > 20 && Celcius < 30)
        {
            Debug.Log("Normal Weather.");
        }
        else if (Celcius > 30 && Celcius < 40)
        {
            Debug.Log("Nice Weather Today");
        }
        else if (Celcius < 35)
        {
            Debug.Log("Nice Weather for Fish n Chips");
        }
        else if (Celcius < 37 && Celcius > 35) 
        {
            Debug.Log("Getting Warmer");
        }
        else if (Celcius > 35 && Celcius < 40)
        {
            Debug.Log("Its hot");
        }
        else
        {
            Debug.Log("IT'S HELL.");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
