using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Blinker : MonoBehaviour {

    public float interval = 1.0f; //点滅する周期
    private float nextTime;
    GameObject gameController;
    private GameObject startLabel;
    

	// Use this for initialization
	void Start () {
        startLabel = GameObject.Find("startLabel");
        nextTime = Time.time;
        gameController = GameObject.FindWithTag("GameController");

	}
	
	// Update is called once per frame
	void Update () {
        if (Time.time > nextTime)
        {
            float alpha = startLabel.GetComponent<CanvasRenderer>().GetAlpha();

            if (alpha == 1.0f)
            {
                startLabel.GetComponent<CanvasRenderer>().SetAlpha(0.0f);
                
            }

            else
            {
                startLabel.GetComponent<CanvasRenderer>().SetAlpha(1.0f);
            }

            nextTime += interval;
        }
	}
}
