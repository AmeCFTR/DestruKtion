using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LastScoreMedium : MonoBehaviour
{

    public Text LastMediumscoreLabel;
    public Text BonusLabel;
    int scores=0;
    int bonusScore = 0;
    int TotalBonus = 0;
    int Bonus;
    void Start()
    {
        scores = 0;
        scores = GameController.ScM(); //GameControllerからmainのスコアを取得 scoresはStart()トークン内で定義されているため他の関数では使えない
        Bonus = Lank.HanteiBonus();


        bonusScore = scores + Lank.hanteiBonus * 100;
        TotalBonus = Lank.hanteiBonus * 100;

        LastMediumscoreLabel.text = "YOUR SCORE : " + bonusScore;
        BonusLabel.text = "PERFECT Bonus +" + TotalBonus;

        /* if (Lank.hanteiBonus > 10&&Lank.hanteiBonus<=29)
         {
             scores += 1000;
             LastMediumscoreLabel.text = "YOUR SCORE : " + scores;
             BonusLabel.text = "PERFECT Bonus +1000";
         }
         else if (Lank.hanteiBonus > 30&&Lank.hanteiBonus<=49)
         {
             scores += 3500;
             LastMediumscoreLabel.text = "YOUR SCORE : " + scores;
             BonusLabel.text = "PERFECT Bonus +3500";
         }
         else if (Lank.hanteiBonus > 50&&Lank.hanteiBonus<=99)
         {
             scores += 6000;
             LastMediumscoreLabel.text = "YOUR SCORE : " + scores;
             BonusLabel.text = "PERFECT Bonus +6000";
         }
         else if (Lank.hanteiBonus > 100)
         {
             scores += 10000;
             LastMediumscoreLabel.text = "YOUR SCORE : " + scores;
             BonusLabel.text = "PERFECT Bonus +10000";
         }
         else if (Lank.hanteiBonus <= 29)
         {
             LastMediumscoreLabel.text = "YOUR SCORE : " + scores;
             BonusLabel.gameObject.SetActive(false);

             // scoreLabel.gameObject.SetActive(true);

             //PlayerPrefs.DeleteAll(); //スコア削除用
         }*/

        //PlayerPrefs.DeleteAll(); //スコア削除用

        Lank.hanteiBonus = 0;
    }

        void Update()
        {

            if (PlayerPrefs.GetInt("HighScoreMedium") < bonusScore)
            {
                PlayerPrefs.SetInt("HighScoreMedium", bonusScore);
            }

            //     int result = GameController.score;
            //   scoreLabel.text = "Your Score : " + result;
        }
    
}
