using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AnVo
{
    public class TriggerZone : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            Debug.Log("I'm through the " + other.gameObject.name); //if you want to be more specific then put like that, otherwise put other.name.

            //we want to move the falling sphere up a bit to fall again 
            other.gameObject.transform.position = new Vector3(0, 5, 0);
            other.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;

        }
    }
}

