using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MazeContrl : MonoBehaviour
{

    private float speed =0.1f;

    void Update()
    {
        if (Input.GetMouseButton(0)&&Time.timeScale.Equals(1))
        {
            transform.Rotate(0f, 0f, -Input.GetAxis("Mouse X") * speed, Space.World); ;
            transform.Rotate(Input.GetAxis("Mouse Y") * speed, 0f, 0f);
        }
    }
    
}
