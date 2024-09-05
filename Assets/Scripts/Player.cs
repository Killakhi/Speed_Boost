using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float horizontal;
    private float vertical;
    [SerializeField] float speed;
    public Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
         horizontal=Input.GetAxis("Horizontal");
         vertical = Input.GetAxis("Vertical");

        Vector2 vector = new Vector2(horizontal, vertical).normalized;
        rb.velocity = vector * speed;
    }
}
