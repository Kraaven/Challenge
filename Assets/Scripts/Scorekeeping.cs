using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Scorekeeping : MonoBehaviour
{
    public float score;

    public TMP_Text showscore;
    // Update is called once per frame

    private void Start()
    {
        showscore = gameObject.GetComponent<TMP_Text>();
    }

    void Update()
    {
        score += Time.deltaTime;
        showscore.text = string.Format("Score: {0:#.0}s", score);
    }
}
