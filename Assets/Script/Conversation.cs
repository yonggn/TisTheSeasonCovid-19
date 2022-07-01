using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public struct Line
{
    public COVIDtalk character;

    [TextArea(1, 3)]
    public string text;
}

 [CreateAssetMenu(fileName ="New Conversation",menuName="Conversation")]
 public class Conversation:ScriptableObject
{
    public COVIDtalk left;
    public COVIDtalk right;
    public Line[] lines;
}

