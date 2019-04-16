using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlinkerWarning : MonoBehaviour
{

    public float interval = 1.0f; //点滅する周期
    private float nextTime;
    GameObject gameController;
    private GameObject warningLabel;


    // Use this for initialization
    void Start()
    {
        warningLabel = GameObject.Find("Warning");
        nextTime = Time.time;
        gameController = GameObject.FindWithTag("GameController");

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextTime)
        {
            float alpha = warningLabel.GetComponent<CanvasRenderer>().GetAlpha();

            if (alpha == 1.0f)
            {
                warningLabel.GetComponent<CanvasRenderer>().SetAlpha(0.0f);

            }

            else
            {
                warningLabel.GetComponent<CanvasRenderer>().SetAlpha(1.0f);
            }

            nextTime += interval;
        }
    }
}
