﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoMediumMainStart : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        Invoke("GoMedium", 4);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void GoMedium()
    {
        SceneManager.LoadScene("main midium");
    }
}
