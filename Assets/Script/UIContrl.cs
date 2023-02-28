using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIContrl : MonoBehaviour
{
    public GameObject canvasStart;
    public GameObject canvasEnd;
    public TextMeshProUGUI timer;
    public static float times;
    private void Start()
    {
        canvasStart=(GameObject)GameObject.Find("StartCanvas");
        canvasEnd = (GameObject)GameObject.Find("EndCanvas");
        canvasEnd.SetActive(false);
        Time.timeScale=0;
    }
    private void Update()
    {
        if (Time.timeScale.Equals(1)) {
            times += Time.deltaTime;
            timer.text = "Time : " + Mathf.Round(times);
        }
       
    }
    public void GameStart()
    {
        canvasStart.SetActive(false);
        Time.timeScale = 1;
    }
    public void GameRestart()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void GameEnd()
    {
#if UNITY_STANDALONE
        Application.Quit();
#endif
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
