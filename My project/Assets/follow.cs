using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class relations : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - target.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (target != null)
        {
            Vector3 newPosition = target.position + target.rotation * offset;
            transform.rotation = target.rotation;
            transform.position = newPosition;
        }
    }
}
