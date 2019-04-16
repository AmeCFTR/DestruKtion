using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Drop2baiItem : MonoBehaviour {

    public GameObject TwobaiItem;
    

    float EncountTimer2;
    public float createTimer2 = 10.0f;
    float RandomX;


	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        EncountTimer2 += Time.deltaTime;
        if (EncountTimer2 >= createTimer2) //EncountTimer2が10を超えたら抽選
        {
            createTwobaiItem();
            EncountTimer2 = 0.0f;

        }

      
	}

    public void createTwobaiItem()
    {
        if (Random.Range(0,11) == 1) //(0,2)以上にする
        {
            RandomX=Random.Range(-3.2f, 3.2f);
            Instantiate(TwobaiItem, new Vector3(RandomX, 4.7f, 0.0f), Quaternion.identity);
        }
    }
}
