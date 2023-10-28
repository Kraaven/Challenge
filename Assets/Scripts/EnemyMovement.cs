using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public GameObject endscreen;
    

    void Update()
    {
        transform.position = new Vector2(transform.position.x - 0.01f, -2.2f);
        if (transform.position.x < -12)
        {
            Destroy(gameObject);
        }
    }


}
