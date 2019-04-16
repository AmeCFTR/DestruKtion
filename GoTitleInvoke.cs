using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoTitleInvoke : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Invoke("GoTitle", 3);
	}

    public void GoTitle()
    {
        SceneManager.LoadScene("Title");
    }
}
