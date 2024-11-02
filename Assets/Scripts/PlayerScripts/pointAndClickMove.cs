using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEditor.Tilemaps;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEngine.GraphicsBuffer;

public class pointAndClickMove : MonoBehaviour
{
    public Vector2 mousePosition;
    public Vector2 targetPosition;
    [SerializeField][Range(0, 0.1f)] private float speed;

    private void FixedUpdate()
    {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetMouseButtonDown(0))
        {
            targetPosition = mousePosition;
            Debug.Log(targetPosition);
        }
        transform.position = Vector2.MoveTowards(transform.position, targetPosition, speed);
    }
}
