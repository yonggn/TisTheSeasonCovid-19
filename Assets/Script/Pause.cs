using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public GameObject PM;
    public static bool paused=false;

    private void Start()
    {
        Update();
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PM.SetActive(true);
            Time.timeScale = 0f;
        }

    }

    public void Resume()
    {
        Time.timeScale = 1f;
        PM.SetActive(false);
    }

    public void LoadMenu(string lvl)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneName:lvl);
    }
    
}
