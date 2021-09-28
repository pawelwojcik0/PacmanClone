using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed;

    private Vector3 direction;
    private Rigidbody2D rigidbody;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        Movement();
    }

    private void Movement()
    {
        if(Input.GetAxisRaw("Horizontal") != 0)
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                direction = Vector2.right;
            }
            else if(Input.GetKey(KeyCode.LeftArrow))
            {
                direction = Vector2.left;
            }
        }
        if(Input.GetAxisRaw("Vertical") != 0)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                direction = Vector2.up;
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                direction = Vector2.down; 
            }
        }

        transform.position += direction * speed * Time.deltaTime;
        rigidbody.MovePosition(transform.position);
    }
}
