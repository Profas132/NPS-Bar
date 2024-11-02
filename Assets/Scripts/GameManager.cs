using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum EventType {
    GoToTable, GoOut, Talk, Order
}

[Serializable]
public class Event
{
    public EventType EventType;
    public int characterId;
}


public class GameManager : MonoBehaviour
{
    public Event[] events;
    [SerializeField] private GameObject[] characters;
    private DialogueUI dialogueUI;

    [SerializeField] private Transform outdoor;
    [SerializeField] private Transform barStage;


    private void Awake()
    {
        EnemyMovement.outdoor = outdoor;
        EnemyMovement.barStage = barStage;

        dialogueUI = GetComponent<DialogueUI>();
        StartCoroutine(GoThroughEvents());
    }


    private IEnumerator GoThroughEvents()
    {
        foreach (var e in events)
        {
            if (e.EventType == EventType.Talk)
            {
                yield return dialogueUI.ShowDialogue();
            }

            if (e.EventType == EventType.GoToTable)
            {
                Debug.Log(characters[e.characterId]);
                yield return characters[e.characterId].GetComponent<EnemyMovement>().GoToTable();
                
            }

            if (e.EventType == EventType.GoOut)
            {
                yield return characters[e.characterId].GetComponent<EnemyMovement>().GoOut();
                
            }
        }
    }

  

}
