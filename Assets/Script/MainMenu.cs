using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string lvl;
    public AudioSource click;
    public void PlayGame()
    {
        PlayerPrefs.SetInt("pills", 0);
        PlayerPrefs.SetInt("lives", 3);
        PlayerPrefs.SetInt("quar", 0);
        SceneManager.LoadScene(sceneName:lvl);
        Debug.Log(PlayerPrefs.GetInt("pills")+" "+PlayerPrefs.GetInt("lives")+"  "+PlayerPrefs.GetInt("quar"));
        click.Play();

    }

   public void QuitGame()
    {
        Application.Quit();
    }
}
