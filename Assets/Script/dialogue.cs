using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.UI;

[System.Serializable]
public class Dialogue
{
    public bool isActive;
    public string name;
    public Sprite image;
    
    [TextArea(3,10)]
    public string[] sentences;
   
}
