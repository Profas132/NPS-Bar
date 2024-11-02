using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    static public Transform outdoor;
    static public Transform barStage;
    [SerializeField] float enemySpeed = 0.1f;

    public Coroutine GoToTable()
    {        
        return StartCoroutine(nameof(goToTable));
    }

    private IEnumerable goToTable()
    {
        
        while (Vector2.Distance(transform.position, barStage.position) > float.Epsilon) {
            Debug.Log("Xd");
            transform.position = Vector2.MoveTowards(transform.position, barStage.position, enemySpeed);
            yield return null;
        }
    }


    public Coroutine GoOut()
    {
        return StartCoroutine(nameof(goOut));
    }

    private IEnumerable goOut()
    {
        while (Vector2.Distance(transform.position, outdoor.position) > float.Epsilon)
        {
            transform.position = Vector2.MoveTowards(transform.position, outdoor.position, enemySpeed);
            yield return null;
        }
    }
}
