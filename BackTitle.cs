using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackTitle : MonoBehaviour {

    public AudioClip audioClip;
    AudioSource audioSource;

	// Use this for initialization
	void Start () {
        audioSource = gameObject.GetComponent<AudioSource>(); //AudioSource内のドラッグ＆ドロップしたSEやBGMを参照
        audioSource.clip = audioClip;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnStartButtonClicked()
    {
        audioSource.Play();
        Invoke("ReturnTitle", 0.49f);
    }

    public void ReturnTitle()
    {
        SceneManager.LoadScene("Title");
    }
}
