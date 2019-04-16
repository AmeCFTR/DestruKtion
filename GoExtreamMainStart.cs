using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoExtreamMainStart : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        Invoke("GoExtream", 4);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void GoExtream()
    {
        SceneManager.LoadScene("main");
    }
}
