using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleCharacterController : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 10; 

    private void Update()
    {
        transform.position += new Vector3(Input.GetAxisRaw("Horizontal") * movementSpeed * Time.deltaTime, 0, Input.GetAxisRaw("Vertical") * movementSpeed * Time.deltaTime);

        // if ya game running at 60 frames per seconds.
        // Time.deltaTime will be equal to 0.167 seconds.
        // - 120 fps = 0.0083 seconds.
        // - 4 fps = 0.25 seconds
    }
}
