using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEditor.PackageManager;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    static public Transform outdoor;
    static public Transform barStage;
    [SerializeField] float enemySpeed = 0.01f;

    public Coroutine GoToTable()
    {        
        return StartCoroutine(goToTable());
    }

    private IEnumerator goToTable()
    {
        while (Vector2.Distance(transform.position, barStage.position) > 0.01f) {            
            transform.position = Vector2.MoveTowards(transform.position, barStage.position, enemySpeed * Time.deltaTime);
            yield return null;
        }
    }

    public Coroutine Order(DialogueUI dialogueUI, Event events)
    {
        return StartCoroutine(StartToOrder(dialogueUI, events));
    }

    private IEnumerator StartToOrder(DialogueUI dialogueUI, Event events)
    {
        dialogueUI.OrderControl(events.TMP_Texts, events.dialogueObject);

        yield return null;
    }

    public Coroutine GoOut()
    {
        return StartCoroutine(nameof(goOut));
    }

    private IEnumerator goOut()
    {
        while (Vector2.Distance(transform.position, outdoor.position) > 0.01f)
        {
            transform.position = Vector2.MoveTowards(transform.position, outdoor.position, enemySpeed * Time.deltaTime);
            yield return null;
        }
    }
}
