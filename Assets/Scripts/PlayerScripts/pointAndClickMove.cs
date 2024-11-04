using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.Burst.CompilerServices;
using Unity.VisualScripting;
using UnityEditor.Tilemaps;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEngine.GraphicsBuffer;

public class pointAndClickMove : MonoBehaviour
{
    public Vector2 mousePosition;
    public Vector2 targetPosition;
    public static bool CanMove = false;
    float starty;
    [SerializeField][Range(0, 0.1f)] private float speed;

    private void Start()
    {
        starty = transform.position.y;        
    }

    private void FixedUpdate()
    {
        if (Input.GetMouseButton(0) && CanMove)
        {
            targetPosition = mousePosition;
        }
        targetPosition = new Vector2(targetPosition.x, starty);
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = Vector2.MoveTowards(transform.position, targetPosition, speed);
    }
}
