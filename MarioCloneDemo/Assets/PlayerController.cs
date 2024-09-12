using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] float moveSpeed;
    [SerializeField] float jumpForce;

    public bool isGrounded = true;

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        Vector3 position = transform.position;
        Vector3 size = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        if (Input.GetButtonDown("Jump") && isGrounded == true)
        {
            Jump();
        }
    }

    private void Move()
    {
        float moveInput = Input.GetAxis("Horizontal");
        transform.Translate(moveInput * Vector2.right * moveSpeed * Time.deltaTime);
    }

    private void Jump()
    {
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        isGrounded = false;
    }

    //public void OnCollisionEnter2d(Collision2D collision)
    //{
    //    if (collision.gameObject.tag == "Ground")
    //    {
    //        isGrounded = true;
    //        Debug.Log("true");
    //    }
    //}
    //public void OnCollisionExit2d(Collision2D collision)
    //{
    //    if (collision.gameObject.tag == "Ground")
    //    {
    //        isGrounded = false;
    //        Debug.Log("false");
    //    }
    //}
}
