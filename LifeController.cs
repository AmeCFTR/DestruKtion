using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeController : MonoBehaviour {

    public LifePanel lifePanel;
    public ShipLife ship;
   // public DestroyRecover recover;


	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	public void Update () {
        lifePanel.UpdateLife(ship.Life());
    }
}
