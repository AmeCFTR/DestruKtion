using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealSound : MonoBehaviour {
    public AudioClip audioClip;
    AudioSource audioSource;
    public GameObject houdai;
    
	// Use this for initialization
	void Start () {
        audioSource = gameObject.GetComponent<AudioSource>(); //AudioSource内のドラッグ＆ドロップしたSEやBGMを参照
        audioSource.clip = audioClip;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D houdai)
    {
        if (houdai.gameObject.tag == "RecoverItem")
        {
            audioSource.Play();
        }
    }
}
