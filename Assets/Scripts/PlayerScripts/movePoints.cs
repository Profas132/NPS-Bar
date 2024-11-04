using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class movePoints : MonoBehaviour
{
    public static movePoints LastClick;
    [SerializeField] private bool getIce;
    [SerializeField] private IngredientType ingredientType;
    public static SpriteRenderer Cup;

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
            Debug.Log(TypeWriterEffect.currentIngredient.ingredientType.ToString() + TypeWriterEffect.currentIngredient.withIce.ToString());
            var startedIngred = TypeWriterEffect.currentIngredient;
            GetComponent<AudioSource>().Play();
            if (gameObject.tag == "Finish")
            {
                TypeWriterEffect.currentIngredient.withIce = false;
                TypeWriterEffect.currentIngredient.ingredientType = IngredientType.none;

            }
            if (TypeWriterEffect.currentIngredient.withIce == true && TypeWriterEffect.currentIngredient.ingredientType == IngredientType.none)
            {
                TypeWriterEffect.currentIngredient.withIce = false;
            }
            if (getIce)
            {
                TypeWriterEffect.currentIngredient.withIce = !TypeWriterEffect.currentIngredient.withIce;
                
            }
            else
            {
                TypeWriterEffect.currentIngredient.ingredientType = ingredientType;
            }

            bool flag = false;
            Debug.Log(TypeWriterEffect.currentIngredient.ingredientType.ToString() + TypeWriterEffect.currentIngredient.withIce.ToString());
            foreach (SpriteByIngred spriteByIngred in GameManager.instance.spriteByIngreds)
            {
                if (spriteByIngred.Ingredient.withIce == TypeWriterEffect.currentIngredient.withIce && spriteByIngred.Ingredient.ingredientType == TypeWriterEffect.currentIngredient.ingredientType)
                {
                    flag = true;
                    Cup.sprite = spriteByIngred.Sprite;
                }
            }
            if (!flag)
            {
                TypeWriterEffect.currentIngredient = startedIngred;
            }
            
            

            

                  


            
        }
    }
}
