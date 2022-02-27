using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_movement : MonoBehaviour
{

    public Transform box_transform;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        transform.position = box_transform.position+offset;
    }
}
