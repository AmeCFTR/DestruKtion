using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NanameBullet : MonoBehaviour
{

    public GameObject bullet1; //使用するゲームオブジェクトの定義
    public Transform muzzle;
    // public static int score;
    // public Text scoreLabel;

    GameObject accurcy;

    public float speed = 1000; //弾速
    public float Des = 2.5f;
    private float timer;
    // Use this for initialization
    void Start()
    {
       accurcy.GetComponent<Bullets>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        //if (Input.GetKeyDown(KeyCode.Q)&&timer>=0.5f)
        if(Input.GetButtonDown("Jump")&&timer>=0.5f) //Yボタン
        {
            Bullets.BulletCount++;
            Debug.Log(Bullets.BulletCount);

            GameObject bullets = GameObject.Instantiate(bullet1) as GameObject; //弾の複製のため,bulletsを定義

            Vector3 force;
            force = this.gameObject.transform.up * speed; //前に進むようにする

            bullets.GetComponent<Rigidbody2D>().AddForce(force);
            bullets.transform.position = muzzle.position;

        }

        if (transform.position.y > Des)
        {
            Destroy(this.gameObject);

        }
    }
    }