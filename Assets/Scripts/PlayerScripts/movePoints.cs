using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePoints : MonoBehaviour
{
    static movePoints LastClick;

    private void OnMouseOver()
    {
        pointAndClickMove.CanMove = true;
        GetComponent<SpriteRenderer>().enabled = true;
    }

    private void OnMouseExit()
    {
        pointAndClickMove.CanMove = false;
        GetComponent<SpriteRenderer>().enabled = false;
    }


    private void OnMouseDown()
    {
        LastClick = GetComponent<movePoints>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && LastClick == this.GetComponent<movePoints>())
        {
            Debug.Log("Налил воды");
        }
    }
}
