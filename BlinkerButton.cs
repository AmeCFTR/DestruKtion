using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlinkerButton : MonoBehaviour {


    private GameObject ButtonTenmetsu;
    private float Step = 0.05f;

    // Use this for initialization
    void Start () {
        this.ButtonTenmetsu = GameObject.Find("Button");
}
	
	// Update is called once per frame
	void Update () {
        float toColor = this.ButtonTenmetsu.GetComponent<Image>().color.a;

        if (toColor < 0 || toColor > 1)
        {
            Step = Step * -1;
        }
        this.ButtonTenmetsu.GetComponent<Image>().color = new Color(255, 255, 255, toColor+Step);
	}
}
