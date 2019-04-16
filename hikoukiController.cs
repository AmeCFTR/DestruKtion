using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hikoukiController : MonoBehaviour {
    GameObject life;
    GameObject houdai;
    Vector3 player;
    public float z = 0f;
    public float speed = 0.15f;

  
    //public GameObject Bullet;

    /*IEnumerator Start()
    {
        while (true)
        {
            
                Instantiate(Bullet, transform.position, transform.rotation);
                yield return new WaitForSeconds(0.7f);
            
        }
    }*/

    void Start()
    {
        life.GetComponent<ShipLife>();
        houdai = GameObject.Find("Houdai");
        
    }

    void Update() {

         /* if (Input.GetButton("Fire2")&&transform.position.x>-3.6f)
           {
               transform.position = new Vector3(transform.position.x - speed, -4.2f, 0f); /*transform.position.xは,現在のx座標から移動するときに使う。
                                                                                        この場合は左クリックされている間、
                                                                                        1フレームごとに、今のx座標から0.15左に移動する。*/
         //  } 
        /* else if (Input.GetButton("Fire1")&&transform.position.x<3.6f)
             {
                 transform.position = new Vector3(transform.position.x + speed, -4.2f, 0f);
             }*/

       // player = new Vector3(transform.position.x, -4.2f, 0f);

        if (transform.position.x > -3.4f && transform.position.x < 3.4f)
        {

            transform.position = new Vector3(transform.position.x + Input.GetAxis("Horizontal"), -4.2f, 0);
            if (transform.position.x < -3.4f) //画面外に行かないようにする
            {
                transform.position = new Vector3(-3.35f, -4.2f, 0f);
            }
            else if (transform.position.x > 3.4f)
            {
                transform.position = new Vector3(3.35f, -4.2f, 0f);
            }

          //  this.transform.position = new Vector3(Mathf.Clamp(player.x, -3.0f, 3.0f), -4.2f);
       }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "RecoverItem")
        {
            this.transform.rotation = Quaternion.Euler(0f, 0f, z); //RecoverItemのtagを持つ相手に当たった時に起こるzのズレを修正する。
            this.transform.position = new Vector3(transform.position.x, -4.2f, 0f);

        } else if(collision.gameObject.tag=="enemy")
        {
            ShipLife.life--;
            Camera.main.SendMessage("Clash");

            this.transform.rotation = Quaternion.Euler(0f, 0f, z); //enemyのtagを持つ相手に当たった時に起こるzのズレを修正する。
            this.transform.position = new Vector3(transform.position.x, -4.2f, 0f);
        }else if(collision.gameObject.tag=="2baiItem")
        {
            this.transform.rotation = Quaternion.Euler(0f, 0f, z); //2baiItemのtagを持つ相手に当たった時に起こるzのズレを修正する。
            this.transform.position = new Vector3(transform.position.x, -4.2f, 0f);
        }
        else if (collision.gameObject.tag == "wall2")
        {
            this.transform.rotation = Quaternion.Euler(0f, 0f, 0f); //2baiItemのtagを持つ相手に当たった時に起こるzのズレを修正する。
            this.transform.position = new Vector3(-3.21f, -4.2f, 0f);
        }
    }
}

