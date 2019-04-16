using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifePanel : MonoBehaviour {
    public GameObject[] Lifeicon;
    int i;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	public void UpdateLife (int life) 
    {
        for (i = 0; i < Lifeicon.Length; i++)
        {
            if (i < life)
            {
                Lifeicon[i].SetActive(true);
            }
            else
            {
                Lifeicon[i].SetActive(false);
            }
        }
        
	}
}
