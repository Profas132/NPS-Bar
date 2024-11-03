using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEditor.PackageManager;
using UnityEngine;
using static UnityEditor.Progress;

public class DialogueUI : MonoBehaviour
{
    private TypeWriterEffect typeWriterEffect;
    private int linesSaid = -1;

    private void Start()
    {
        typeWriterEffect = GetComponent<TypeWriterEffect>();
    }

    public Coroutine OrderControl(Event _event)
    {
        linesSaid++;
        Debug.Log("Заказ");
        return typeWriterEffect.Run(_event.dialogueObject.dialogueClasses[linesSaid].dialogue, _event.TMP_Texts, _event.dialogueObject.dialogueClasses[linesSaid]);
    }
}