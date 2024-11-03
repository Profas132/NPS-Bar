using System.Collections;
using System.Collections.Generic;
using TMPro;
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
            transform.position = Vector2.MoveTowards(transform.position, barStage.position, enemySpeed);
            yield return null;
        }
    }


    public Coroutine GoOut()
    {
        return StartCoroutine(nameof(goOut));
    }

    private IEnumerator goOut()
    {
        while (Vector2.Distance(transform.position, outdoor.position) > 0.01f)
        {
            transform.position = Vector2.MoveTowards(transform.position, outdoor.position, enemySpeed);
            yield return null;
        }
    }
}
