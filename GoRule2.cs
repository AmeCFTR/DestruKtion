using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoRule2 : MonoBehaviour {
    AudioSource audioSource;
    public AudioClip audioClip;

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
        Invoke("GoToRule2", 0.49f);
       
    }

    void GoToRule2()
    {
        SceneManager.LoadScene("Rule2");
    }
}
