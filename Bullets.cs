using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bullets : MonoBehaviour {

    public GameObject bullet1; //使用するゲームオブジェクトの定義
    public Transform muzzle;
    public static float BulletCount=0;

    // public static int score;
    // public Text scoreLabel;
   

    public float speed = 1000; //弾速

    private float timer;


	// Use this for initialization
	void Start () {
        timer = 0;
    }

    // Update is called once per frame
    void Update() {
        timer += Time.deltaTime; //マイフレームごとに時間取得

        //if (Input.GetKeyDown(KeyCode.A)&&timer>=0.5f) {
        if (Input.GetButtonDown("Fire1")&&timer>=0.5f) { //GP Fire3 Bボタン
            BulletCount++; //命中率の時に使う

            
            GameObject bullets = GameObject.Instantiate(bullet1) as GameObject; //弾の複製のため,bulletsを定義

            Vector3 force;
            force = this.gameObject.transform.up * speed; //前に進むようにする

            bullets.GetComponent<Rigidbody2D>().AddForce(force); //弾丸に前に進むための力を加える

            bullets.transform.position = muzzle.position; //弾丸生成位置をmuzzleの位置にする
            

        }
        
        if (transform.position.y > 4.6f)
        {
            Destroy(this.gameObject);
           
        }
        
    }
    /*void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            score += 100;
            scoreLabel.text = "SCORE : " + score;
            Debug.Log("Plus Score");
        }
    }*/

}





