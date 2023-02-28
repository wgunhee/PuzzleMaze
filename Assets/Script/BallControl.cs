using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    public GameObject endCanvas;
    public GameObject playCanvas;
    public TextMeshProUGUI tex;
    private void Update()
    {
        if (gameObject.transform.position.y < -30f)
        {
            gameObject.transform.position = new Vector3(-20f,8f, 22f );
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.tag);
        if (other.tag .Equals("EndPoint"))
        {
            Debug.Log("end");
            endCanvas.SetActive(true);
            playCanvas.SetActive(false);
            tex.text = "End Time : " + Mathf.Round(UIContrl.times);
            Time.timeScale = 0;
        }
    }
}
