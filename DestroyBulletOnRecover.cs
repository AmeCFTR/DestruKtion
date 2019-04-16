using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBulletOnRecover : MonoBehaviour
{
    public GameObject bullet1;
    public GameObject RecoverItem;
    public AudioClip audioClip;
   // AudioSource audioSource;

    public float ItemDropPercent = 1.5f;
    public int NormalEnemyHP = 1;
    public static int DestroyEnemyCount;
    Explosion explosion;
    Guard guard; //使っていない

   
    float random;
    
    void Start()
    {
        // RecoverItem.SetActive(false);
        bullet1.SetActive(true);
        explosion = GetComponent<Explosion>();
        guard = GetComponent<Guard>();
        GameObject.Find("invincibleWall");
        NormalEnemyHP = 1; //HP数を変えたいときはここをいじる
        //audioSource = gameObject.GetComponent<AudioSource>(); //AudioSource内のドラッグ＆ドロップしたSEやBGMを参照
        //audioSource.clip = audioClip;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D bullet1)
    {
        Debug.Log("Damage"); //ここまでは実行されている

        if (bullet1.gameObject.tag == "Bullt1")  //←GuardはDestroyされているためGuardHpを取得できていない？ 呼び出されていない boolを使うか
        {
            NormalEnemyHP--;
        }
        if (NormalEnemyHP <= 0)
        {
            random = Random.Range(0f, 101.0f); //0から100までで乱数を取得

            if (random <= ItemDropPercent)
            { //出た乱数が10以下だったらitemdrop関数を呼び出す

                itemdrop();
            }
            else
            {
                explosion.CallExplosion(); //敵を倒した場所に爆発エフェクトを呼び出す
                Destroy(this.gameObject);
                AudioSource.PlayClipAtPoint(audioClip, transform.position);
            }
        }

        if (bullet1.gameObject.tag == "ship") //船に当たった時は一発で消える
        {
            Destroy(this.gameObject);
            explosion.CallExplosion();
        }
        DestroyEnemyCount++; //PERFECTを取ったら2が足され、GOODを取ったら1が足される ゲージの増減に使う
    }

     void OnDestroy()
    {
        
        // audioSource.Play();
    }

    public void itemdrop() //回復アイテムドロップの処理
    {
        GameObject.FindGameObjectsWithTag("enemy"); //どのオブジェクトに適用させるかを決めるためのFind。今回はenemyがアイテムを落とすのでenemyをFindする。
            explosion.CallExplosion();
            Destroy(this.gameObject);
            Instantiate(RecoverItem, gameObject.transform.position, Quaternion.identity); //上のFind("enemy")でenemyという名前を持つゲームオブジェクトを見つけ、
                                                                                          //それがDestroyされた時に,その場所にRecoverItemを生成している

        Debug.Log("HealItemDrop");
        }
        
    }
