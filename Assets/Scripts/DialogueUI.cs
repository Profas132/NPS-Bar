using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DialogueUI : MonoBehaviour
{
    [SerializeField] private TMP_Text textlabel;
    private TypeWriterEffect typeWriterEffect;
    [SerializeField] private DialogueObject testDialogue;

    private void Start()
    {
        typeWriterEffect = GetComponent<TypeWriterEffect>();
        ShowDialogue(testDialogue);
    }

    public void ShowDialogue(DialogueObject dialogueObject)
    {
        StartCoroutine(StepThroughDialogue(dialogueObject));
    }

    private IEnumerator StepThroughDialogue(DialogueObject dialogueObject)
    {
        foreach (string dialogue in dialogueObject.dialogue)
        {
            yield return typeWriterEffect.Run(dialogue, textlabel);
        }
    }

}
