using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DialogueUI : MonoBehaviour
{
    private TypeWriterEffect typeWriterEffect;
    [SerializeField] private DialogueObject dialogueObject;
    [SerializeField] private TMP_Text[] TMP_Texts;

    private void Start()
    {
        typeWriterEffect = GetComponent<TypeWriterEffect>();
        ShowDialogue(dialogueObject);
    }

    public void ShowDialogue(DialogueObject dialogueObject)
    {
        StartCoroutine(StepThroughDialogue(dialogueObject));
    }

    private IEnumerator StepThroughDialogue(DialogueObject dialogueObject)
    {
        for (int i = 0; i < dialogueObject.dialogue.Length; i++)
        {
            yield return typeWriterEffect.Run(dialogueObject.dialogue[i], TMP_Texts[dialogueObject.speakersId[i]]);
        }
    }

}
