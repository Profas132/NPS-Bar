using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePoints : MonoBehaviour
{
    public static movePoints LastClick;
    [SerializeField] private bool getIce;
    [SerializeField] private IngredientType ingredientType;
    [SerializeField] private Transform Cup;

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
            GetComponent<AudioSource>().Play();

                

            if (getIce)
            {
                TypeWriterEffect.currentIngredient.withIce = !TypeWriterEffect.currentIngredient.withIce;
            } else TypeWriterEffect.currentIngredient.ingredientType = ingredientType;
        }
    }
}
