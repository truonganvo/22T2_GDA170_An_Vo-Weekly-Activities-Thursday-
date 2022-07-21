using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeekEight : MonoBehaviour
{
    // Start is called before the first frame update
    public enum Fruit
    {
        banana,
        apple,
        orange,
        dfhdsaf,
        GGGGGGG,
        
    }

    public Fruit myFavouriteFruit;
    public Fruit[] myFruitBasket = new Fruit[6];

    // Update is called once per frame
    private void Start()
    {
        myFavouriteFruit = Fruit.apple;
        //Debug.Log("YAY " + myFavouriteFruit);

        for (int i = 0; i < myFruitBasket.Length; i++)
        {
            //myFruitBasket[i] = Fruit.apple;
            Debug.Log("The Fruit I picked out of my basket was " + myFruitBasket[i]);

            CheckFruit(myFruitBasket[i]);
        }
    }

    private void CheckFruit(Fruit typeOfFruit)
    {
        // We want to output different text depending on which fruit was chosen
        //If it is an apple, do X
        //If it is an banana, do Y
        //...etc
        switch (typeOfFruit)
        {
            case Fruit.banana: Debug.Log("THIS IS THE ONE BOIS");
                //THIS IS THE ONE
                break;
            case Fruit.apple: Debug.Log("ANOTHER ONE FOUND");
                break;
            case Fruit.orange:
                break;
            case Fruit.dfhdsaf:
                break;
            case Fruit.GGGGGGG:
                break;
            default:
                break;
        }
    }

}
