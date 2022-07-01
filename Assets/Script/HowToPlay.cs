using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HowToPlay : MonoBehaviour
{
    public GameObject panel1;
    public GameObject panel2;
    public GameObject howtoplay;
    public AudioSource click;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
            howtoplay.SetActive(true);
    }


    public void AtPanel1()
    {
        click.Play();
        panel1.SetActive(false);
        panel2.SetActive(true);
    }

    public void AtPanel2()
    {
        click.Play();
        Destroy(howtoplay);
    }

    
}
