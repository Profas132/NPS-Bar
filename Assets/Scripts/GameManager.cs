using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum Event {
    GoToTable, GoOut, Talk, Order
}

public class GameManager : MonoBehaviour
{
    public Event[] events;
    private DialogueUI dialogueUI;

    private void Start()
    {
        dialogueUI = GetComponent<DialogueUI>();
        StartCoroutine(GoThroughEvents());
    }


    private IEnumerator GoThroughEvents()
    {
        foreach (var e in events)
        {
            if (e == Event.Talk)
            {
                yield return dialogueUI.ShowDialogue();
            }

            if (e == Event.GoToTable)
            {

            }

            if (e == Event.GoOut)
            {

            }

        }
    }

  

}
