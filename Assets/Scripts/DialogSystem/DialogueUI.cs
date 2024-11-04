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

    private void Start()
    {
        typeWriterEffect = GetComponent<TypeWriterEffect>();
    }

    public Coroutine OrderControl(Event _event, dialogueClass dialogueClass)
    {
        Debug.Log("�����");
        return typeWriterEffect.Run(dialogueClass.dialogue, _event.TMP_Texts, dialogueClass);
    }
}