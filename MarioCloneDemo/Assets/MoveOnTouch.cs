using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOnTouch : MonoBehaviour
{
    [SerializeField] float speed;
    private float startLocation;
    private float endLocation;
    [SerializeField] float distance;
    private Vector3 direction = Vector3.up;
    private bool isColliding = false;
    private bool directionUp = false;

    // Start is called before the first frame update
    void Start()
    {
        startLocation = transform.position.y;

        endLocation = startLocation + distance;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (transform.position.y >= endLocation)
        {
            if (isColliding)
            {
                directionUp = false;
            }
        }
        else if (transform.position.y <= startLocation)
        {
            if (isColliding)
            {
                directionUp = true;
            }
        }
        if (isColliding)
        {
            HandleMovement();
        }
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            isColliding = true;
            HandleMovement();
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            isColliding = false;
        }
    }

    private void HandleMovement()
    {
        if (directionUp == false)
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        } else
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
    }
}
