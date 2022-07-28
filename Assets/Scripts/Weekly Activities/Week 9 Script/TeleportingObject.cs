using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AnVo
{
    public class TeleportingObject : MonoBehaviour
    {
        private Vector3 resetPosition;

        private void OnEnable()
        {
            //Start Listening to our "Space Bar Press" event.
            EventManager.OnClicked += Teleport;
        }

        private void OnDisable()
        {
            //Stop listening to our "Space Bar Press" event.
            EventManager.OnClicked -= Teleport;
        }

        private void Start()
        {
            resetPosition = transform.position;
        }
        private void Teleport()
        {
            transform.position = resetPosition;
        }
    }
}

