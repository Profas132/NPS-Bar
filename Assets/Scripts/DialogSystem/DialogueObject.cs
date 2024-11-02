using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;


[CreateAssetMenu(menuName ="Dialogue/DialogueObject")]


public class DialogueObject : ScriptableObject 
{

    [SerializeField, TextArea] public string[] dialogue;
    [SerializeField] public int[] speakersId;

}
