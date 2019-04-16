using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NEWBullets : MonoBehaviour {

    /* public float speed = 10.0f;
     // Use this for initialization
     void Start () {
         GetComponent<Rigidbody2D>().velocity = transform.up * speed;
     }

     // Update is called once per frame
     void Update () {



     }*/

    
        public int speed; // 弾のスピード

        // スクリプトが有効になったとき一回だけ呼ばれます
        void Start()
        {
            speed = 5;
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, speed); // 上向きに速度を渡してあげます
        }
    
}
