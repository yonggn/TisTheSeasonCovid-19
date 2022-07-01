using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class loadscr : MonoBehaviour
{
    public GameObject loadingScreen;
    public Slider slider;
   public void LoadLvl(string sceneName)
    {
        StartCoroutine(LoadAsync(sceneName));
        Time.timeScale = 1f;
    }

    IEnumerator LoadAsync (string sceneName)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneName);
        loadingScreen.SetActive(true);
        while(!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / 1f);
            Debug.Log(progress+sceneName);
            slider.value = progress;
            yield return null;
        }

    }
}
