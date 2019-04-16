using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoEasyMainStart : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        Invoke("GoEasy", 4);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void GoEasy()
    {
        SceneManager.LoadScene("main easy");
    }
}
