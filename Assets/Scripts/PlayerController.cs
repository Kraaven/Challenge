using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    private bool OnGround;

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && OnGround)
        {
            rb.velocity = new Vector2(0, 7);
            OnGround = false;
        }

        if (Input.GetMouseButtonDown(1))
        {
            rb.velocity += new Vector2(0, -12);
        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Ground_T")
        {
            OnGround = true;
            Debug.Log("On Ground");
        }
    }
    
}
