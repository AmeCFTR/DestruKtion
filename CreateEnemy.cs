using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateEnemy : MonoBehaviour {

    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;
    public GameObject enemy4;
    public GameObject HPenemy1;

    GameObject CatchStartGame;

    float random1;
    float random2;
    float random3;
    float random4;
    float random5;

    float randomY1;
    float randomY2;
    float randomY3;
    float randomY4;
    float randomY5;

    float EncountTimer;
    float EncountTimer2;
    float EncountTimer3;

    public float createTimer=1.05f;
    public float createTimer2 = 1.0f;
    public float createTimer3 = 5.0f;
    public float ControlInstantiateTime;

    public static float EnemyCount; //敵を生成した数を数える

	// Use this for initialization
	void Start () {
        CatchStartGame.GetComponent<GameController>();
	}
	// Update is called once per frame
	void FixedUpdate () {

        if (GameController.StartGame == true) //GameControllerのStartGameがtrueの間は敵を作り続ける。falseの時は作らない
        {
            EncountTimer += Time.deltaTime; //秒数をEncountTimer変数に代入。1秒ごとに1ずつ足されていく
            if (EncountTimer >= createTimer) //EncountTimer変数が1.05秒を超えるたびにcreateEnemy関数を呼び出す。
            {
                createEnemy();
                EncountTimer = 0.0f; //createEnemy関数呼び出し後、EncountTimer変数を初期化
            }

            EncountTimer2 += Time.deltaTime;
            if (EncountTimer2 >= createTimer2)
            {
                createEnemy2();
                EncountTimer2 = 0.0f;
            }

            EncountTimer3 += Time.deltaTime;
            if (EncountTimer3 >= createTimer3)
            {
                createEnemy3();
                EncountTimer3 = 0;
            }
        }
    }

    public void createEnemy()
    {

        if (Random.Range(0, 3) == 0)
        {
            random1 = Random.Range(-3.1f,-1.4f);
            randomY1 = Random.Range(5.8f, 9.0f);
            Instantiate(enemy1, new Vector3(random1, randomY1, 0.0f), enemy1.transform.rotation);
            EnemyCount++;
            
        }


        else if (Random.Range(0, 3) >= 2)
        {
            random3 = Random.Range(0.5f,1.9f);
            randomY3 = Random.Range(7.8f, 9.5f);

            Instantiate(enemy3, new Vector3(random3, randomY3, 0.0f), enemy3.transform.rotation);
            EnemyCount++;
           
        }

     
    }

    public void createEnemy2()
    {
        if (Random.Range(0, 3) >= 2)
        {
            random2 = Random.Range(-1.1f, 0.2f);
            randomY2 = Random.Range(9.0f, 11.5f);
            Instantiate(enemy2, new Vector3(random2, randomY2, 0.0f), enemy2.transform.rotation);
            EnemyCount++;
           
        }

        else if (Random.Range(0, 3) <= 3)
        {
            random4 = Random.Range(2.3f, 3.1f);
            randomY4 = Random.Range(10.1f, 13.0f);
            Instantiate(enemy4, new Vector3(random4, randomY4, 0.0f), enemy4.transform.rotation);
            EnemyCount++;
            
        }
    }

    public void createEnemy3()
    {
        if (Random.Range(0, 5) >= 4){
            random5 = Random.Range(-2.9f, 2.9f);
            randomY5 = Random.Range(5.8f, 9.0f);
            Instantiate(HPenemy1, new Vector3(random5, randomY5, 0.0f), HPenemy1.transform.rotation);
            EnemyCount++;
        }
    }
}
