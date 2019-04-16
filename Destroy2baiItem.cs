using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy2baiItem : MonoBehaviour {

    float TwobaiHantei;
    public GameObject TwobaiItem;
    public static bool TwobaiUp = false;
    public static float TwobaiTime = 0f;

	// Use this for initialization
	void Start () {
        TwobaiHantei = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D TwobaiItem)
    {
        Destroy(this.gameObject);
        TwobaiHantei++;
        TwobaiUp = true;

        TwobaiTime += Time.deltaTime;
        


    }
}
