using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighClearTrigger : MonoBehaviour {
    GameObject gameController;

	
	void Start () {
        gameController = GameObject.FindWithTag("GameController");
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Bullt1")
        {
            gameController.SendMessage("DontScore");
           

        }else if(other.gameObject.tag=="RecoverItem")
        {
            gameController.SendMessage("DontScore");
        }
        else 
        {
            gameController.SendMessage("HighIncreaseScore");
            
        }
    }
}
