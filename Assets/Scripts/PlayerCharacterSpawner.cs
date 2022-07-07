using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacterSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    // - Make a character Prefab
    // - A reference to that Prefab (a variable) 
    // - Spawn it ("Instantiate")

    [SerializeField] private GameObject playerPrefab;
    [SerializeField] private Transform playerSpawnPoint; 

    void Start()
    {
        Instantiate(playerPrefab, playerSpawnPoint.position, Quaternion.identity); //Quaternion.identity = return player back to normal = 0
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
