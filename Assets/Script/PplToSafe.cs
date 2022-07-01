using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class PplToSafe : MonoBehaviour
{
    public GameObject[] ppl;
    private List<GameObject> pepl;
    public int index;
    public int quarantine;
    public int count;
    public GameObject noone;
    public int Pills;
    public Text pillno;
    public GameObject nopills;
    public GameObject currentppl;
    private void Start()
    {
        quarantine = PlayerPrefs.GetInt("quar", 0);
        Pills = PlayerPrefs.GetInt("pills", 0);
        pillno.text = Pills.ToString();
        pepl=ppl.ToList<GameObject>();
        Debug.Log(PlayerPrefs.GetInt("quar") + " " + quarantine);
       count = quarantine;
        if (quarantine == 0)
        {
            noone.SetActive(true);
        }
        else
        {
            noone.SetActive(false);
            Choose();
        }
        
    }

    public void Choose()
    {
            index = Random.Range(0, pepl.Count);
            currentppl = pepl[index];
            Display();
            pepl.RemoveAt(index);
        
        if(count==0)
        { 
            noone.SetActive(true);
        }

    }

    void Display()
    {
        currentppl.SetActive(true);
    }

    public void Safe()
    {
        quarantine--;
        Pills -= 2;
        pillno.text = Pills.ToString();
        if(Pills<2)
        {
            nopills.SetActive(true);
            pepl[index].SetActive(false);
        }
        else
        {
            nopills.SetActive(false);
        }
        count--;
        currentppl.SetActive(false);
        pepl.Remove(currentppl);
        Choose();
    }

    public void Pass()
    {
        currentppl.SetActive(false);
        pepl.Remove(currentppl);
        count--;
        Choose();
    }
    public void OnDestroy()
    {
        PlayerPrefs.SetInt("quar", quarantine);
        PlayerPrefs.SetInt("pills", Pills);
    }
}
