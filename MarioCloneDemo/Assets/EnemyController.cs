using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    [SerializeField] float moveSpeed;
    [SerializeField] float jumpForce;

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(5 * Vector2.left * Time.deltaTime);
        Vector3 charScale = transform.localScale;
        //charScale.x += 2 * Time.deltaTime;
        //charScale.y += 2 * Time.deltaTime;
        //transform.localScale = charScale;
    }

}