using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallDanger : MonoBehaviour {
    AudioSource audioSource;
    public AudioClip audioClip;

 
	// Use this for initialization
	void Start () {
        audioSource = gameObject.GetComponent<AudioSource>(); //AudioSource内のドラッグ＆ドロップしたSEやBGMを参照
        audioSource.clip = audioClip;

        int danger=ShipLife.life;
    }
	
	// Update is called once per frame
	void Update () {
        if (ShipLife.life == 1)
        {
            audioSource.Play();
        }
	}
}
