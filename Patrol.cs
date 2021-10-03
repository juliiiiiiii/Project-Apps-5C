using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{

    public float speed;
    public float distance;

    private bool moveRight = true;

    public Transform GroundCheck;

    private void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
        RaycastHit2D ground = Physics2D.Raycast(GroundCheck.position, Vector2.down, distance);

        if(ground.collider == false)
        {
            if (moveRight == true)
            {
                transform.Rotate(0f, 180f, 0f);
                moveRight = false;
            }
            else
                transform.Rotate(0f, 0f, 0f);
            moveRight = true;
        }
    }

}
