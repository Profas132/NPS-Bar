using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class pointAndClickMove : MonoBehaviour
{
    public Vector2 mousePosition;
    public Vector2 targetPosition;
    [SerializeField][Range(0,10)] private float speed;

    private void Update()
    {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetMouseButton(0))
        {
            Vector2 targetPosition = mousePosition;
            if (this.transform.position.x != targetPosition.x)
            {
                this.transform.position = Vector2.Lerp(this.transform.position, targetPosition, speed * Time.deltaTime);
            }
            //
            //transform.Translate(targetPosition);        
        }
    }
}
