using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour {
    public GameObject ExplosionAnime;
    float timer;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void CallExplosion()
    {
        //GameObject explosionAnime = GameObject.Instantiate(ExplosionAnime) as GameObject;
        Instantiate(ExplosionAnime, transform.position, transform.rotation);

        Destroy(this.gameObject, 0.6f);
    }

}
