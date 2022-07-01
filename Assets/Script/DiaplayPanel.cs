using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiaplayPanel : MonoBehaviour
{
    public GameObject tutorial;
    public GameObject panel1;
    public GameObject panel2;
    public GameObject panel3;
    public GameObject panel4;
    public AudioSource click;

    public void AtPanel1()
    {
        click.Play();
        panel1.SetActive(false);
        panel2.SetActive(true);
        panel3.SetActive(false);
        panel4.SetActive(false);
    }

    public void AtPanel2()
    {
        click.Play();
        panel1.SetActive(false);
        panel2.SetActive(false);
        panel3.SetActive(true);
        panel4.SetActive(false);
    }

    public void AtPanel3()
    {
        click.Play();
        panel1.SetActive(false);
        panel2.SetActive(false);
        panel3.SetActive(false);
        panel4.SetActive(true);
    }

    public void EndDisplay()
    {
        click.Play();
        Destroy(tutorial);
    }

}
