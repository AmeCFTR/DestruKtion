using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBullet : MonoBehaviour
{
    public GameObject bullet1;
   public static int hantei = 0;
    
    // Use this for initialization
    void Start()
    {
        hantei = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D bullet1)
    {
        hantei++; //1つ当たると+1、2つ当たると+2
        Destroy(gameObject);
        if (bullet1.gameObject.tag == "Guard")
        {
            Destroy(this.gameObject);
        }
}

     
}