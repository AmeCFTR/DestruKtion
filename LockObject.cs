using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockObject : MonoBehaviour {

    public GameObject jaming;
    Rigidbody rigidbody;

	// Use this for initialization
	void Start () {
        rigidbody.constraints = RigidbodyConstraints.FreezeAll;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
