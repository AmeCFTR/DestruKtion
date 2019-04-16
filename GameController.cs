using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
    enum State
    {
        Ready,
        Play,
        GameOver
    }

    //public HikoukiController hikouki;
    State state;
    public Text scoreLabel;
    public Text EasyscoreLabel;
    public Text MediumscoreLabel;
    public Text HiddenscoreLabel;
    public Text Warning;
    public Text timer;

    public static int score;
    public static int scoreEasy;
    public static int scoreMedium;
    public static int scoreHidden;

    public static bool StartGame;

    public static int Sc() //のちのLastScoreスクリプトで最終スコアを取得するためにスコアを常時返し続ける
    {
        return score;
    }

    public static int ScE()
    {
        return scoreEasy;
    }

    public static int ScM()
    {
        return scoreMedium;
    }
    public static int ScH()
    {
        return scoreHidden;
    }

    public Text startLabel;
    public Text gameOverLabel;
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;
    public GameObject enemy4;

    public GameObject Bullet;
    public GameObject Bullet2;
    public GameObject NanameBullet1;
    public GameObject NanameBullet2;
    
    GameObject GameOverItem;
    GameObject TwobaiItem2;
    GameObject catchTimer;
    GameObject catchTimer2;
    GameObject catchTimer3;
    GameObject catchTimer4;
    

    void Start ()
    {

        Ready();

        score = 0;
        scoreEasy = 0;
        scoreMedium = 0;
        scoreHidden = 0;

        GameOverItem.GetComponent<ShipLife>();
        TwobaiItem2.GetComponent<Destroy2baiItem>();
        catchTimer.GetComponent<CountDown>();
        catchTimer2.GetComponent<CountDownEasy>();
        catchTimer3.GetComponent<CountDownMedium>();
        catchTimer4.GetComponent<CountDownHidden>();

    }

    void LateUpdate()
    {
        switch (state)
        {
            case State.Ready:
                Invoke("GameStart", 3.0f);
                break;

            case State.Play:
               // Debug.Log("Game Start State");
                if (ShipLife.life <= 0||CountDown.time<=0||CountDownEasy.time<=0||CountDownMedium.time<=0||CountDownHidden.time<=0) //カウントダウンが0になったらゲームオーバー
                {
                    CallGameOver();
                }
                break;

            case State.GameOver:

                break;
        }
    }
	
	void Ready () {
        //state = State.Ready;
        /*TateScrollObject[] tatescrollObjects = GameObject.FindObjectsOfType<TateScrollObject>();
        foreach (TateScrollObject so in tatescrollObjects) so.enabled = false; */
    
        state = State.Ready;
        
        ShipLife.life = 3; //life初期化

        StartGame = false;

        scoreLabel.gameObject.SetActive(true);
        EasyscoreLabel.gameObject.SetActive(true);
        MediumscoreLabel.gameObject.SetActive(true);
        HiddenscoreLabel.gameObject.SetActive(true);
        Warning.gameObject.SetActive(false);
        startLabel.gameObject.SetActive(true);
        gameOverLabel.gameObject.SetActive(false);
        timer.gameObject.SetActive(false);

        Bullet.SetActive(true);
        Bullet2.SetActive(true);
        NanameBullet1.SetActive(true);
        NanameBullet2.SetActive(true);

        enemy1.SetActive(false);
        enemy2.SetActive(false);
        enemy3.SetActive(false);
        enemy4.SetActive(false);

    }

    void GameStart()
    {
       state = State.Play;

        /*  TateScrollObject[] tatescrollObjects = GameObject.FindObjectsOfType<TateScrollObject>();
          foreach (TateScrollObject so in tatescrollObjects) so.enabled = true; */

        StartGame = true;

        scoreLabel.gameObject.SetActive(true);
        EasyscoreLabel.gameObject.SetActive(true);
        MediumscoreLabel.gameObject.SetActive(true);
        HiddenscoreLabel.gameObject.SetActive(true);
        Warning.gameObject.SetActive(false);

        startLabel.gameObject.SetActive(false);
        gameOverLabel.gameObject.SetActive(false);
        timer.gameObject.SetActive(true);

        Bullet.SetActive(true);
        Bullet2.SetActive(true);
        NanameBullet1.SetActive(true);
        NanameBullet2.SetActive(true);

        enemy1.SetActive(true);
        enemy2.SetActive(true);
        enemy3.SetActive(true);
        enemy4.SetActive(true);
    }

    void CallGameOver()
    {

        state = State.GameOver;

        StartGame = false;

        scoreLabel.gameObject.SetActive(true);
        EasyscoreLabel.gameObject.SetActive(true);
        MediumscoreLabel.gameObject.SetActive(true);
        HiddenscoreLabel.gameObject.SetActive(true);
        Warning.gameObject.SetActive(false);

        startLabel.gameObject.SetActive(false);
        gameOverLabel.gameObject.SetActive(true);
        timer.gameObject.SetActive(true);

        Bullet.SetActive(false);
        Bullet2.SetActive(false);
        NanameBullet1.SetActive(false);
        NanameBullet2.SetActive(false);

        enemy1.SetActive(false);
        enemy2.SetActive(false);
        enemy3.SetActive(false);
        enemy4.SetActive(false);

        
        
    }

    public void IncreaseScore()
    {
        
        score += 100;
        scoreEasy += 100;
        scoreMedium += 100;
        scoreHidden += 100;
        scoreLabel.text = "SCORE : " + score;
        EasyscoreLabel.text = "SCORE : " + scoreEasy;
        MediumscoreLabel.text = "SCORE : " + scoreMedium;
        HiddenscoreLabel.text = "SCORE : " + scoreHidden;
        if (Destroy2baiItem.TwobaiUp==true)
        {

            score += 100;
            scoreEasy += 100;
            scoreMedium += 100;
            scoreHidden += 100;

            Invoke("scoreReturn", 10);

        }
        

    }

    public void HighIncreaseScore()
    {
        score += Random.Range(1,500);
        scoreEasy += Random.Range(1, 500);
        scoreMedium += Random.Range(1, 500);
        scoreLabel.text = "SCORE : " + score;
        EasyscoreLabel.text = "SCORE : " + scoreEasy;
        MediumscoreLabel.text = "SCORE : " + scoreMedium;
    }

    public void NanameIncreaseScore()
    {
        score += 30;
        scoreEasy += 30;
        scoreMedium += 30;
        scoreHidden += 30;
        scoreLabel.text = "SCORE : " + score;
        EasyscoreLabel.text = "SCORE : " + scoreEasy;
        MediumscoreLabel.text = "SCORE : " + scoreMedium;
        HiddenscoreLabel.text = "SCORE : " + scoreHidden;

        if (Destroy2baiItem.TwobaiUp == true)
        {

            score += 30;
            scoreEasy += 30;
            scoreMedium += 30;
            scoreHidden += 30;

            Invoke("scoreReturn", 10);

        }
    }

    public void DontScore()
    {
        score += 0;
        scoreEasy += 0;
        scoreMedium += 0;

        scoreLabel.text = "SCORE : " + score;
        EasyscoreLabel.text = "SCORE : " + scoreEasy;
        MediumscoreLabel.text = "SCORE : " + scoreMedium;
    }
    
    public void scoreReturn()
    {
        Destroy2baiItem.TwobaiUp = false;
        Destroy2baiItem.TwobaiTime = 0;

    }

}
