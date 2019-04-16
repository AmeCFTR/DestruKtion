using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyRecover : MonoBehaviour
{
    public GameObject RecoverItem;
   
    GameObject recoverlifeControll; //life変数を見つけるための変数

    // Use this for initialization
    void Start()
    {
        recoverlifeControll = GameObject.Find("life");
        recoverlifeControll.GetComponent<ShipLife>(); //GetComponentでShipLifeのスクリプトの変数も使えるようになった
                                                      //↑ただし、ShipLifeのスクリプトもアタッチしている必要がある

   
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D col)
   {
        if (col.gameObject.tag == "Houdai")
        {
            ShipLife.life++; //lifeはstaticで定義されている
            Destroy(this.gameObject);
            Debug.Log("Destroy heaiItem!");
        }
   }
    
}