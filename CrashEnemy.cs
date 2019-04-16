using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashEnemy : MonoBehaviour {
    public GameObject enemy;
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

    void OnCollisionEnter2D(Collision2D enemy)
    {
        if (enemy.gameObject.tag =="Bullt1")
        {
            audioSource.Play();
            Debug.Log("SE");
        }
    }
}
