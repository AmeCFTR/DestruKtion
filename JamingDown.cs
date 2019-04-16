using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JamingDown : MonoBehaviour {

    public GameObject Jaming;
   public float downJam;
   
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(0, -1 * downJam * Time.deltaTime, 0);

        if (transform.position.y <= 2.6f)
        {
            downJam = 0;
        }
    }
}
