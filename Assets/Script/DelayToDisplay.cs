using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DelayToDisplay : MonoBehaviour
{
    public GameObject button;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(display());
        
    }

    // Update is called once per frame
    void DelayDisplay()
    {
        
    }

    IEnumerator display()
    {
        yield return new WaitForSeconds(2);
        button.SetActive(true);
    }
}
