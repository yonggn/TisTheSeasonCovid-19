using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TypeWritter : MonoBehaviour
{
    public float speed=0.1f;
    [TextArea(5,50)]
    public string fullText;

    private string currentText="";
    IEnumerator ShowText()
    {
        for(int i=0;i<fullText.Length;i++)
        {
            currentText = fullText.Substring(0, i);
            this.GetComponent<Text>().text = currentText;
            yield return new WaitForSeconds(speed);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ShowText());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
