﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoHiddenMainStart : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        Invoke("GoHidden", 4);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void GoHidden()
    {
        SceneManager.LoadScene("main EX");
    }
}
