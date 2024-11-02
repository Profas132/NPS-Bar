using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePoints : MonoBehaviour
{
    private void OnMouseOver()
    {
        pointAndClickMove.CanMove = true;
    }

    private void OnMouseExit()
    {
        pointAndClickMove.CanMove = false;
    }

}
