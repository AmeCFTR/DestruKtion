using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyExplode : MonoBehaviour {
    public GameObject ExplosionAnime;

	// Use this for initialization
	void Start () {
        Invoke("DestroyExp", 0.5f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void DestroyExp()
    {
        Destroy(gameObject);
    }
}
