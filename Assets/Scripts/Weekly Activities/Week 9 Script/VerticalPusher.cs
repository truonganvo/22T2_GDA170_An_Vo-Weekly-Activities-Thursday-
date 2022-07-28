using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AnVo
{
    public class VerticalPusher : MonoBehaviour
    {
        [SerializeField] private Vector3 pushForce;

        private void OnEnable()
        {
            EventManager.OnClicked += MovingUp;
        }

        private void OnDisable()
        {
            EventManager.OnClicked -= MovingUp;
        }

        private void MovingUp()
        {
            gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero; // reset to Zero to avoid super high jump
            gameObject.GetComponent<Rigidbody>().AddForce(pushForce);
        }
    }
}
