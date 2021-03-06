﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountDown : MonoBehaviour {

    public static float time = 181.0f;
    public Text timer;

	// Use this for initialization
	void Start () {
        time = 181.0f;
	}
	
	// Update is called once per frame
	void Update () {
        time -= Time.deltaTime;

        if (time < 0)
        {
            time = 0;
            Invoke("GoGameOver", 3.5f);
        }

        timer.text = "残り時間：" + time;

	}

    void GoGameOver()
    {
        SceneManager.LoadScene("GameOver");
    }
}
