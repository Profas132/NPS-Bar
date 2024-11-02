using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanDissapear : MonoBehaviour
{
    
    public void Hide()
    {
        GetComponentInChildren<Image>().enabled = false;
    }

    public void Show()
    {
        GetComponentInChildren<Image>().enabled = true;
    }

}
