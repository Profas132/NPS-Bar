
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public enum EventType {GoToTable1, GoToTable2, GoOut, Order}

[Serializable]
public class Event
{
    public EventType EventType;
    public GameObject characters;
    public TMP_Text TMP_Texts;
    public DialogueObject dialogueObject;
}

[Serializable]
public class SpriteByIngred
{
    public Ingredient Ingredient;
    public Sprite Sprite;
}

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Event[] events;
    private DialogueUI dialogueUI;
    [SerializeField] private Transform outdoor;
    [SerializeField] private Transform barStage1;
    [SerializeField] private Transform barStage2;
    [SerializeField] private SpriteRenderer cup;
    [SerializeField] public SpriteByIngred[] spriteByIngreds;

    private void Start()
    {
        
        if (instance == null)
        {
            instance = this;
        }

        movePoints.Cup = cup;
        EnemyMovement.outdoor = outdoor;
        EnemyMovement.barStage1 = barStage1;
        EnemyMovement.barStage2 = barStage2;

        dialogueUI = GetComponent<DialogueUI>();
        StartCoroutine(GoThroughEvents());
    }

    private IEnumerator GoThroughEvents()
    {
        
        foreach (var e in events)
        {            
            if (e.EventType == EventType.GoToTable1)
            {
                SoundManager.instance.playDoorBellSound();
                yield return e.characters.GetComponent<EnemyMovement>().GoToTable1();   
            }
            if (e.EventType == EventType.GoToTable2)
            {
                SoundManager.instance.playDoorBellSound();
                yield return e.characters.GetComponent<EnemyMovement>().GoToTable2();
            }

            if (e.EventType == EventType.Order)
            {
                foreach (var i in e.dialogueObject.dialogueClasses)
                {
                    SoundManager.instance.playDialogueSound();
                    yield return e.characters.GetComponent<EnemyMovement>().Order(dialogueUI, e, i);
                }
            }

            if (e.EventType == EventType.GoOut)
            {
                yield return e.characters.GetComponent<EnemyMovement>().GoOut();
                SoundManager.instance.playDoorBellSound();
            }
        }
    }
}
