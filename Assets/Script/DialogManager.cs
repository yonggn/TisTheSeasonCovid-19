using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour
{
    public GameObject dialogueWindow;
    public Text nameText;
    public Text sentenceText;
    public Image cha;
    private Queue<string> sentences;
    public float speed = 0.05f;
    

    void Start()
    {
        sentences = new Queue<string>();
    }

   
    public void StartDialogue(Dialogue dialogue)
    {
        Debug.Log("Start"+dialogue.name);
        
        nameText.text = dialogue.name;
        cha.sprite = dialogue.image;
        sentences.Clear();
        foreach(string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
        dialogueWindow.SetActive(true);
        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        
            if (sentences.Count == 0)
            {
                EndDialogue();
                return;
            }
            string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(typeSentence(sentence));
        
    }

    IEnumerator typeSentence(string sentence)
    {
        sentenceText.text = "";
        foreach(char letter in sentence.ToCharArray())
        {
            sentenceText.text += letter;
            yield return new WaitForSeconds(speed);
        }
    }

    void EndDialogue()
    {
        dialogueWindow.SetActive(false);
        Time.timeScale = 1f;
        Debug.Log("End of conversation");
        /*ObjectNo += 1;
        ObjectN.text = ObjectNo.ToString();
        Destroy(collision.gameObject);*/
    }

}
