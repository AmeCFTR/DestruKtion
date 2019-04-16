using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPenemy : MonoBehaviour
{
    public GameObject bullet1;
    public GameObject RecoverItem;
    public AudioClip audioClip;
    // AudioSource audioSource;

    public float ItemDropPercent = 1.5f;
    public static int DestroyEnemyCount;
    Explosion explosion;

    public int EnemyHp=3;

    GameController gameController;

    float random;

    void Start()
    {
        // RecoverItem.SetActive(false);
        bullet1.SetActive(true);
        EnemyHp = 3;
        //audioSource = gameObject.GetComponent<AudioSource>(); //AudioSource内のドラッグ＆ドロップしたSEやBGMを参照
        //audioSource.clip = audioClip;

        gameController = gameObject.GetComponent<GameController>();
        explosion = GetComponent<Explosion>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D bullet1) 
    {
        if (bullet1.gameObject.tag=="Bullt1")
        {


            EnemyHp--; //弾丸に当たるとEnemyHpが1減る。0になると消滅

            GameController.score += 50; //HPenemyはボーナス点あり、PERFECT時は250点、GOOD時は150点
            GameController.scoreEasy += 50;
            GameController.scoreMedium += 50;
            GameController.scoreHidden += 50;
        }

        if (EnemyHp <= 0) //EnemyHpが0になったときの処理
        {
            random = Random.Range(0f, 101.0f); //0から100までで乱数を取得
            if (random <= ItemDropPercent)
            { //出た乱数が10以下だったらitemdrop関数を呼び出す

                itemdrop();
            }
            else //10以上だったら普通に消滅
            {
                Destroy(this.gameObject); 
                AudioSource.PlayClipAtPoint(audioClip, transform.position);

                explosion.CallExplosion();
            }
        }

        DestroyEnemyCount++; //PERFECTを取ったら2が足され、GOODを取ったら1が足される


        if (bullet1.gameObject.tag == "ship") //船に当たった時は一発で消える
        {
            Destroy(this.gameObject);
            explosion.CallExplosion();
        }

    }

    void OnDestroy()
    {

        // audioSource.Play();
    }

    public void itemdrop()
    {
        GameObject.Find("enemy"); //どのオブジェクトに適用させるかを決めるためのFind。今回はenemyがアイテムを落とすのでenemyをFindする。

        Destroy(this.gameObject);
        Instantiate(RecoverItem, gameObject.transform.position, Quaternion.identity); //上のFind("enemy")でenemyという名前を持つゲームオブジェクトを見つけ、
        explosion.CallExplosion();          //それがDestroyされた時に,その場所にRecoverItemを生成している

    }
}