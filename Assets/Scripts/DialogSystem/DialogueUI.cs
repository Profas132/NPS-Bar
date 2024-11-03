using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;
using static UnityEditor.Progress;

public class DialogueUI : MonoBehaviour
{
    private TypeWriterEffect typeWriterEffect;
    //[SerializeField] private DialogueObject dialogueObject;
    private int linesSaid = -1;

    private void Start()
    {
        typeWriterEffect = GetComponent<TypeWriterEffect>();
        //ShowDialogue();
    }

    public Coroutine ShowDialogue(TMP_Text texts, DialogueObject dialogueObject)
    {
        linesSaid++;
        Debug.Log("52");
        return typeWriterEffect.Run(dialogueObject.dialogueClasses[linesSaid].dialogue, texts);
    }

    public Coroutine OrderControl(TMP_Text texts, DialogueObject dialogueObject)
    {
        linesSaid++;
        Debug.Log("Заказ");
        return typeWriterEffect.Run(dialogueObject.dialogueClasses[linesSaid].dialogue, texts);
    }
}