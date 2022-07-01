using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class enterlevel : MonoBehaviour
{
    public GameObject enterWindow;
    public string lvl;
    
    public AudioSource bgm;


    public void Start()
    {
        Time.timeScale = 1f;
        bgm.Play();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            windowOut();
        }

    }

    public void windowOut()
    {
        
        Time.timeScale = 0f;
        enterWindow.SetActive(true);
    }

    public void enter(string lvl)
    {
       
        SceneManager.LoadScene(sceneName:lvl);
        Time.timeScale = 1f;
        PlayerPrefs.SetInt("pillsInGame", 0);
            
    }

    public void notready()
    {
    
        
        enterWindow.SetActive(false);
       
        if(bgm.isPlaying)
        {
            bgm.Stop();
        }
        Start();
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.tag=="Player")
        {
            enterWindow.SetActive(false);
        }
    }
}
