using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPbar : MonoBehaviour
{
    Slider slider;
    const float DefaultInvincible = 0.0f;
    public static float hp=DefaultInvincible;
    public GameObject ship;
    public GameObject invincibleShip;
    public Text InvincibleLabel;

    public float invincibleTime = 20.0f;

   DestroyBulletOnRecover CatchDestroyEnemyCount; //呼び出すスクリプトを型に定義したほうが良い
    
    public float Default()
    {
        return hp;
    }

    void Start()
    {
        slider = GameObject.Find("HPbar").GetComponent<Slider>(); //シーンビューにあるHPbarという名前のゲームオブジェクトにスライダーを対応させる。
        CatchDestroyEnemyCount=gameObject.GetComponent<DestroyBulletOnRecover>();

        ship.SetActive(true);
        invincibleShip.SetActive(false);
        InvincibleLabel.gameObject.SetActive(false);

        hp = 0.0f;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (DestroyBulletOnRecover.DestroyEnemyCount>=2) 
        {
            hp += 0.035f;
            DestroyBulletOnRecover.DestroyEnemyCount = 0;
        }
        else if (DestroyBulletOnRecover.DestroyEnemyCount==1)
        {
            hp += 0.0125f;
            DestroyBulletOnRecover.DestroyEnemyCount = 0;
        }

        else if (DestroyBulletOnRecover.DestroyEnemyCount >= 3) //念のため
        {
            DestroyBulletOnRecover.DestroyEnemyCount = 0;
        }

        if (hp >= 1.0f) //最大まで溜まったら
        {
            
            ship.SetActive(false);
            invincibleShip.SetActive(true);
            InvincibleLabel.gameObject.SetActive(true);
            
            Invoke("ReturnShip", invincibleTime);
        }

        slider.value = hp; //スライダーがhpを表示させるようにする。これによりスライダーがhpの中の数によって変化する
    }

    public void ReturnShip()
    {
        
        ship.SetActive(true);
        invincibleShip.SetActive(false);
        InvincibleLabel.gameObject.SetActive(false);

        if (hp >= 1.0f)
        {
            hp = 0.0f;
        }
    }
}
   