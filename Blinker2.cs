using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Blinker2 : MonoBehaviour
{

    public float interval = 1.0f; //点滅する周期
    private float nextTime;
    GameObject gameController;
    private GameObject gameOverLabel;


    // Use this for initialization
    void Start()
    {
        gameOverLabel = GameObject.Find("GameOverLabel");
        nextTime = Time.time;
        gameController = GameObject.FindWithTag("GameController");

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextTime)
        {
            float alpha = gameOverLabel.GetComponent<CanvasRenderer>().GetAlpha();

            if (alpha == 1.0f)
            {
                gameOverLabel.GetComponent<CanvasRenderer>().SetAlpha(0.0f);

            }

            else
            {
                gameOverLabel.GetComponent<CanvasRenderer>().SetAlpha(1.0f);
            }

            nextTime += interval;
        }
    }
}
