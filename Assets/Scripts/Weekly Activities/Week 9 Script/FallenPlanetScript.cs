using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AnVo
{
    public class FallenPlanetScript : MonoBehaviour
    {
        public int planetDamage = 5;

        private void OnCollisionEnter (Collision collision)
        {
            collision.gameObject.GetComponent<PlayerHealth>().playerHealth -= planetDamage;     
        }
    }
}

