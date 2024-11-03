using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TypeWriterEffect : MonoBehaviour
{
    [SerializeField] private float typewriterSpeed = 50f;
    public bool InWork = false;

    public Coroutine Run(string textToType, TMP_Text textlabel, dialogueClass dialogue)
    {
        return StartCoroutine(TypeText(textToType, textlabel, dialogue));
    }

    private IEnumerator TypeText(string textToType, TMP_Text textlabel, dialogueClass dialogue)
    {
        InWork = true;
        textlabel.GetComponentInParent<CanDissapear>().Show();
        textlabel.text = string.Empty;
        
        float t = 0;
        int charIndex = 0;

        while (charIndex < textToType.Length)
        {
            t += Time.deltaTime * typewriterSpeed;
            charIndex = Mathf.FloorToInt(t);
            charIndex = Mathf.Clamp(charIndex, 0, textToType.Length);

            textlabel.text = textToType.Substring(0, charIndex);

            yield return null;
        }

        if (dialogue.type == DialogType.order)
        {
            while (checkIngredient(dialogue.ingredient))
            {
                yield return null;
            }
        }
        else
        {
            while (!Input.anyKey)
            {
                yield return null;
            }
        }
        
        yield return new WaitForSeconds(1);
        textlabel.GetComponentInParent<CanDissapear>().Hide();
        textlabel.text = string.Empty;
        InWork = false;
    }

    public bool checkIngredient(IngredientGen ingredient)
    {
        
        return false;
    }
}
