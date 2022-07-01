using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogTrigger : MonoBehaviour
{
    public GameObject dialogueWindow;
    public Dialogue dialogue;
    private Queue<string> sentences;
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            
            triggered();
        }

    }

    private void triggered()
    {
        FindObjectOfType<DialogManager>().StartDialogue(dialogue);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            dialogueWindow.SetActive(false);
        }

    }

   
   
}    

