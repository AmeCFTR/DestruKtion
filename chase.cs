using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chase : MonoBehaviour {

    public float speed = 10.0f;
    public float rotationSmooth = 1.0f;

    private Transform player;

	// Use this for initialization
	void Start () {
        player = GameObject.Find("Houdai").transform; 
	}
	
	// Update is called once per frame
	void Update () {
        Quaternion targetRotation = Quaternion.LookRotation(player.position - transform.position); //player.positionはHoudaiの位置
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * rotationSmooth);

        transform.Translate(Vector3.up * speed * Time.deltaTime);
	}
}
