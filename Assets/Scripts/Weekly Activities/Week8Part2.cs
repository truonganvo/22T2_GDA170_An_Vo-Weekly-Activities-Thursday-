using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Week8Part2 : MonoBehaviour
{
    void Start()
    {
        for (int i = 1; i < 101; i++)
        {
            if ((i%3 == 0) && (i%5 == 0))
            {
                Debug.Log("FizzBuzz");
            }
            else if (i%5 == 0)
            {
                Debug.Log("Buzz");
            }
            else if (i % 3 == 0)
            {
                Debug.Log("Fizz");
            }
            else
            {
               Debug.Log("Current Number " + i);
            }
        }
    }

}
