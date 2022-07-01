using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterStore : MonoBehaviour
{
    public GameObject enterWindow;
    public string lvl;

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
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneName: lvl);
        PlayerPrefs.GetInt("pill");

    }

    public void notready()
    {
        Time.timeScale = 1f;
        enterWindow.SetActive(false);
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            enterWindow.SetActive(false);
        }
    }
}
