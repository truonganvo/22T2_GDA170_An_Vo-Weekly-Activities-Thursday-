using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Week3 : MonoBehaviour
{
    public int PowerLevel;
    private int strength = 2;
    private int agility = (int)1.5;
    private int intelligence = 0;

    public string PlayerOnePower;
    public string PlayerTwoPower;
    // Start is called before the first frame update
    void Start()
    {
        PowerLevel = strength + agility + intelligence;

        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
