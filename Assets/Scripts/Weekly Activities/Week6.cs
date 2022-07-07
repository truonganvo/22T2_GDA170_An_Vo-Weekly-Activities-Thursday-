using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Week6 : MonoBehaviour
{
    [SerializeField] private Material materialRed;
    [SerializeField] private Material materialGreen;

    Vector3 startingPosition;
    Transform cachedTransform;
    private Renderer mr;

    // Start is called before the first frame update
    private void Start()
    {
        cachedTransform = transform;
        startingPosition = cachedTransform.position;
        mr = GetComponent<Renderer>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (cachedTransform.position.x >= 0)
        {
            mr.material.color = new Color(0f, 1f, 0f, 0f);
        }
        else
        {
            mr.material.color = new Color(1f, 0f, 0f, 0f);
        }
    }
}
