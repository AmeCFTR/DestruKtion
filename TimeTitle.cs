using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimeTitle : MonoBehaviour {

    public float timeOut;
    private float timeElapsed;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timeElapsed += Time.deltaTime;

        if (timeElapsed >= timeOut)
        {
            SceneManager.LoadScene("Title");
        }
    }
}
