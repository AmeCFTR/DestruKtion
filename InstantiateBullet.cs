using UnityEngine;
using System.Collections;

public class InstantiateBullet : MonoBehaviour
{
    public GameObject Tama; // 弾のオブジェクト

    public static int count; // 発射間隔

    int frame; // フレーム

    // スクリプトが有効になったとき一回だけ呼ばれます
    void Start()
    {
        frame = 5;
        count = 2;
    }
    // 毎フレーム呼ばれます
    void Update()
    {
        frame++; // フレームをカウント

        //Zキーを押しているときかつ10フレームごと
        if (Input.GetKey(KeyCode.A) && frame % count == 0)
        {
            Instantiate(Tama, new Vector2(transform.position.x, transform.position.y), Quaternion.identity); // プレイヤーの位置に弾を生成します 
        }
    }
}
