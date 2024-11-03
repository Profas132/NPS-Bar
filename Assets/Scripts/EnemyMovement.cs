using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEditor.PackageManager;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    static public Transform outdoor;
    static public Transform barStage1;
    static public Transform barStage2;
    [SerializeField] float enemySpeed = 0.01f;

    public Coroutine GoToTable1()
    {        
        return StartCoroutine(goToSpot(barStage1));
    }

    public Coroutine GoToTable2()
    {
        return StartCoroutine(goToSpot(barStage2));
    }

    public Coroutine GoOut()
    {
        return StartCoroutine(goToSpot(outdoor));
    }
    private IEnumerator goToSpot(Transform spot)
    {
        while (Vector2.Distance(transform.position, spot.position) > 0.01f) {            
            transform.position = Vector2.MoveTowards(transform.position, spot.position, enemySpeed * Time.deltaTime);
            yield return null;
        }
    }

    public Coroutine Order(DialogueUI dialogueUI, Event events)
    {
        return StartCoroutine(StartToOrder(dialogueUI, events));
    }

    private IEnumerator StartToOrder(DialogueUI dialogueUI, Event events)
    {
        yield return dialogueUI.OrderControl(events);
    }

    

    
}
