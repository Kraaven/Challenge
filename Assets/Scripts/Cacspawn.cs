using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Cacspawn : MonoBehaviour
{
    public GameObject enemy;
    public bool IsRunning = false;
    private float interval = 0;
    private float waittime;
    private bool spawned;
    private void Start()
    {
        Invoke("game", 2);
    }

    void game()
    {
        IsRunning = true;
        spawned = true;
    }

    private void Update()
    {
        if (IsRunning)
        {
            if (spawned)
            {
                if (waittime == 0)
                {
                    waittime = Random.Range(0.5f, 2.5f);
                }
                
                if (interval < waittime)
                {
                    interval += Time.deltaTime;

                }
                else
                {
                    Instantiate(enemy, new Vector2(11.5f,-2.2f), Quaternion.identity);
                    interval = 0;
                    waittime = 0;
                }
            }

          
            




        }
    }
}
