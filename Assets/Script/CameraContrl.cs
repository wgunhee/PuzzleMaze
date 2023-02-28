using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraContrl : MonoBehaviour
{
    public GameObject ball;
    void Update()
    {
        transform.position = new Vector3(ball.transform.position.x, ball.transform.position.y + 15f, ball.transform.position.z);
    }
}
