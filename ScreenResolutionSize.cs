using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenResolutionSize : MonoBehaviour {

    [RuntimeInitializeOnLoadMethod]
	static void OnRuntimeMethodLoad()
    {
        // Screen.SetResolution(650, 810, false); //完成サイズ
        Screen.SetResolution(660, 810, false);
    }
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
