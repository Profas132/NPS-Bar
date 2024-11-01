using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TypeWriterEffect : MonoBehaviour
{
    [SerializeField] private float typewriterSpeed = 50f;

    public Coroutine Run(string textToType, TMP_Text textlabel)
    {
        return StartCoroutine(TypeText(textToType, textlabel));
    }

    private IEnumerator TypeText(string textToType, TMP_Text textlabel)
    {
        textlabel.text = string.Empty;
        textlabel.enabled = true;
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
        yield return new WaitForSeconds(3);
        textlabel.enabled = false; // 
    }

}
