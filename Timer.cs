using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    [SerializeField]
    private int minute;
    [SerializeField]
    private float seconds;

    private float oldSeconds;
    private Text timerLabel;

	// Use this for initialization
	void Start () {
        minute = 0;
        seconds = 0.0f;
        oldSeconds = 0.0f;
        timerLabel = GetComponentInChildren<Text>();

	}
	
	// Update is called once per frame
	void Update () {
        seconds += Time.deltaTime;
        if (seconds >= 60.0f)
        {
            minute++;
            seconds = seconds - 60;
        }

        else if ((int)seconds != (int)oldSeconds)
        {
            timerLabel.text = "経過時間  "+minute.ToString("00") + ":" + ((int)seconds).ToString("00");
        }
        oldSeconds = seconds;
	}
}
