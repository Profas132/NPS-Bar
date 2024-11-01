using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[CreateAssetMenu(menuName ="Dialogue/DialogueObject")]



public class DialogueObject : ScriptableObject 
{
    [SerializeField][TextArea] public string[] dialogue;    

}
