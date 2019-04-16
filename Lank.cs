using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lank : MonoBehaviour
{ 
    public Text perfectLabel;
    public Text goodLabel;
    public static int hanteiBonus;
    public static int GoodCount;
    public static int PerfectCount;

    GameObject gameObject;

    public static int HanteiBonus() //LastScore系で呼び出される
    {
        return hanteiBonus;
    }

    public static int ReturnGoodCount()
    {
        return GoodCount;
    }
   
    public static int ReturnPerfectCount()
    {
        return PerfectCount;
    }
    
    void Start()
    {
        
        perfectLabel.gameObject.SetActive(false);
        goodLabel.gameObject.SetActive(false);
        gameObject.GetComponent<DestroyBullet>();
        //GoodCount = 0;
       // PerfectCount = 0;
        //hanteiBonus = 0;
    }

    void Update()
    {
        if (DestroyBullet.hantei == 1) //Goodを表示させる
        {
            perfectLabel.gameObject.SetActive(false);
            goodLabel.gameObject.SetActive(true);
            DestroyBullet.hantei = 0; //初期化して判定をリセット、これで毎回出るようになる
            GoodCount++; //Good数表示用

            Invoke("DestroyText", 0.8f);


        }

        else if (DestroyBullet.hantei == 2) //Perfectを表示させる
        {
            perfectLabel.gameObject.SetActive(true);
            goodLabel.gameObject.SetActive(false);
            DestroyBullet.hantei = 0;
            PerfectCount++; //Perfect数表示用
            hanteiBonus++; //ボーナス用カウント



            Invoke("DestroyText", 0.8f);

        }
    }

    public void DestroyText() //文字消滅用関数
    {
        perfectLabel.gameObject.SetActive(false);
        goodLabel.gameObject.SetActive(false);
    }
}
