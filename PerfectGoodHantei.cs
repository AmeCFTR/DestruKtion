using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PerfectGoodHantei : MonoBehaviour {

    public Text PerfectCountLabel;
    public Text GoodCountLabel;

    GameObject gameObject;
   
    // Use this for initialization
    void Start() {
        gameObject.GetComponent<Lank>();
    }
	
	// Update is called once per frame
	void Update () {
        PerfectCountLabel.text = "Total PERFECT : " + Lank.PerfectCount;
        GoodCountLabel.text = "Total GOOD : " + Lank.GoodCount;
        Invoke("ResetCount", 3);
	}

    private void ResetCount()
    {
        Lank.GoodCount = 0;
        Lank.PerfectCount = 0;
    }
}
