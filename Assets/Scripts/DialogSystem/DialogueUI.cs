using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;
using static UnityEditor.Progress;

public class DialogueUI : MonoBehaviour
{
    private TypeWriterEffect typeWriterEffect;
    [SerializeField] private DialogueObject dialogueObject;
    [SerializeField] private TMP_Text[] TMP_Texts;
    private int linesSaid = -1;

    private void Start()
    {
        typeWriterEffect = GetComponent<TypeWriterEffect>();
        //ShowDialogue();
    }

    public Coroutine ShowDialogue()
    {
        linesSaid++;
        Debug.Log("52");
        return typeWriterEffect.Run(dialogueObject.dialogueClasses[linesSaid].dialogue, TMP_Texts[dialogueObject.dialogueClasses[linesSaid].speakersId]);
    }
}