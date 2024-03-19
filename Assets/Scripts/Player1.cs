using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    private float boundaryLimit = 4.5f;
    // move up and down using w and s keys
    public float speed = 0.005f;
    
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) // move up
        {
            Vector2 newPosition = new Vector2(transform.position.x, transform.position.y + speed);

            if (newPosition.y < boundaryLimit)
            {
                transform.position = newPosition;
            }
            else
            {
                transform.position = new Vector2(transform.position.x, boundaryLimit);
            }
            
        }
        else if (Input.GetKey(KeyCode.S)) // move down
        {
            Vector2 newPosition = new Vector2(transform.position.x, transform.position.y - speed);
            
            if (newPosition.y > -boundaryLimit)
            {
                transform.position = newPosition;
            }
            else
            {
                transform.position = new Vector2(transform.position.x, -boundaryLimit);
            }
        }
    }
}
