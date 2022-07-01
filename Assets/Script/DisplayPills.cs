using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DisplayPills : MonoBehaviour
{
    public int pillNo;
    public Text pill;
    public int lifeNo;
    public GameObject cannot;
    public GameObject shop;
    

    private void Start()
    {
        DiaplayPill();
        if (pillNo < 10)
        {
            cannot.SetActive(true);
            shop.SetActive(false);
        }
    }

    public void DiaplayPill()
    {
        pillNo=PlayerPrefs.GetInt("pills");
        pill.text = pillNo.ToString();
       
    }

    public void ReducedPill()
    {
        pillNo -= 10;
         PlayerPrefs.SetInt("pills", pillNo);

    }

    public void AddLife()
    {
        lifeNo=PlayerPrefs.GetInt("lives",0);
        lifeNo++;
        PlayerPrefs.SetInt("lives", lifeNo);
        Debug.Log("life +1");
    }

    private void OnDestroy()
    { 
       
        Debug.Log("Destroyed" + PlayerPrefs.GetInt("pills"));
    }
}
