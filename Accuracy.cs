using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Accuracy : MonoBehaviour {

    float BulletAccuracy;
    GameObject CallEnemyCount;
    GameObject CallBulletCount;
    public Text AccuracyLabel;

	// Use this for initialization
	void Start () {
        CallBulletCount.GetComponent<Bullets>();
        CallEnemyCount.GetComponent<CreateEnemy>();
	}
	
	// Update is called once per frame
	void Update () {

        if (BulletAccuracy > 100)
        {
            BulletAccuracy = 100;
        }

        if (CreateEnemy.EnemyCount > Bullets.BulletCount)
        {
            CreateEnemy.EnemyCount = Bullets.BulletCount;
        }


        BulletAccuracy = (CreateEnemy.EnemyCount / Bullets.BulletCount) * 100; //命中率計算

        AccuracyLabel.text = "Accuracy : " + BulletAccuracy.ToString("f1")+"％";

       
	}
}
