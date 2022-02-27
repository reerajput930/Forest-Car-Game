using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxMovement : MonoBehaviour
{
    
    public float movez;
    public float movex;
   
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)){
            transform.position -= new Vector3(movex, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= new Vector3(0, 0,movez);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(0, 0, movez);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(movex, 0, 0);
        }
        
    }
}
