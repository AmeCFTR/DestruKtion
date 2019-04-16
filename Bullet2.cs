using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet2 : MonoBehaviour
{

    public GameObject bullet2; //使用するゲームオブジェクトの定義
    public Transform muzzle2;

    public float speed = 1000; //弾速

    private float timer;

    // Use this for initialization
    void Start()
    {
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
      //  if (Input.GetKeyDown(KeyCode.A) && timer >= 0.5f)
      if(Input.GetButtonDown("Fire1")&&timer>=0.5f) //GP
        {
            GameObject bullets = GameObject.Instantiate(bullet2) as GameObject; //弾の複製のため,bulletsを定義
            Vector3 force;
            force = this.gameObject.transform.up * speed; //前に進むようにする


            bullets.GetComponent<Rigidbody2D>().AddForce(force);
            bullets.transform.position = muzzle2.position;
        }
            if (transform.position.y > 4.6f)
            {
                Destroy(this.gameObject);

            }
        
    }
}
