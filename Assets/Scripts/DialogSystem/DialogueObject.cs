using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;


[CreateAssetMenu(menuName = "Dialogue/DialogueObject")]

public class DialogueObject : ScriptableObject
{
    public dialogueClass[] dialogueClasses;
}

[Serializable]
public class dialogueClass
{
    public string dialogue;
    public DialogType type;
    public IngredientGen ingredient;
    //public EnemyMovement speakersId;
}

public enum DialogType { notOrder, order }

