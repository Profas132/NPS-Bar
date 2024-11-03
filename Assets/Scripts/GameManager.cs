using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public enum EventType {GoToTable, GoOut, Talk, Order}

[Serializable]
public class Event
{
    public EventType EventType;
    public GameObject characters;
    public TMP_Text TMP_Texts;
    public DialogueObject dialogueObject;
}

public class GameManager : MonoBehaviour
{
    public Event[] events;
    private DialogueUI dialogueUI;
    [SerializeField] private Transform outdoor;
    [SerializeField] private Transform barStage;
    [SerializeField] private Transform barStage2;

    private void Awake()
    {
        EnemyMovement.outdoor = outdoor;
        EnemyMovement.barStage = barStage;
        EnemyMovement.barStage = barStage2;

        dialogueUI = GetComponent<DialogueUI>();
        StartCoroutine(GoThroughEvents());
    }

    private IEnumerator GoThroughEvents()
    {
        foreach (var e in events)
        {
            if (e.EventType == EventType.Talk)
            {
                yield return dialogueUI.ShowDialogue(e);
            }

            if (e.EventType == EventType.GoToTable)
            {
                Debug.Log(events);
                yield return e.characters.GetComponent<EnemyMovement>().GoToTable();   
            }

            if (e.EventType == EventType.Order)
            {
                yield return e.characters.GetComponent<EnemyMovement>().Order(dialogueUI, e);
            }

            if (e.EventType == EventType.GoOut)
            {
                yield return e.characters.GetComponent<EnemyMovement>().GoOut();
            }
        }
    }
}
