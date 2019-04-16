using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class chargeBullet : MonoBehaviour
{

    public GameObject ChargeBullet; //使用するゲームオブジェクトの定義
    public Transform muzzle3;
    public static int score;
    public Text scoreLabel;

    public float speed = 1000; //弾速
    public AudioClip audioClip;
    AudioSource audioSource;

    // Use this for initialization
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>(); //AudioSource内のドラッグ＆ドロップしたSEやBGMを参照
        audioSource.clip = audioClip;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Z))
        {
            audioSource.Play();

            GameObject bullets = GameObject.Instantiate(ChargeBullet) as GameObject; //弾の複製のため,bulletsを定義。 
            Vector3 force;
            force = this.gameObject.transform.up * speed; //transform.upはゲームオブジェクトが前に進むようにする

            bullets.GetComponent<Rigidbody2D>().AddForce(force);
            bullets.transform.position = muzzle3.position; //muzzle3の場所に弾を置く

        }

            if (transform.position.y > -0.5f)
            {
                Destroy(this.gameObject);
            }


        
    }

        /*void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.tag == "enemy")
            {
                score += 300;
                scoreLabel.text = "SCORE : " + score;
                Debug.Log("Plus Score");
            }

        }*/
  }