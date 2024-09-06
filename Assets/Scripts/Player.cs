using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float horizontal;
    private float vertical;
    static float speed = 5f;
    public Rigidbody2D rb;
    public Speedbar speedbar;
    public float currentBoostSpeed;
    public bool isBoosted;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        currentBoostSpeed = 0;
        speedbar.fastorNot(0);
    }
    public void getSpeed(float sp)
    {
        currentBoostSpeed += sp;
        speedbar.fastorNot(currentBoostSpeed);
        speed =+ 10f * currentBoostSpeed;
        
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Speed"))
        {
            Destroy(other.gameObject);
            getSpeed(1);

        }
    }
    // Update is called once per frame
    void Update()
    {
         horizontal =Input.GetAxis("Horizontal");
         vertical = Input.GetAxis("Vertical");

        Vector2 vector = new Vector2(horizontal, vertical).normalized;
        rb.velocity = vector * speed;
    }

}
