using System.Collections;
using UnityEngine;

//これをbullet,bullet1にアタッチすることでスコア加算がされる

public class ClearTrigger : MonoBehaviour
{
    GameObject gameController;


    void Start()
    {
        //ゲーム開始時にGameControllerをFindにしておく
        gameController = GameObject.FindWithTag("GameController");

    }

    //トリガーからExitしたらクリアとみなす
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Bullt1")
        {
            gameController.SendMessage("DontScore");
            
        }
        else if (other.gameObject.tag == "RecoverItem")
        {
            gameController.SendMessage("DontScore");
        }
        else if (other.gameObject.tag == "2baiItem")
        {
            gameController.SendMessage("DontScore");
        }
        else
        {
            gameController.SendMessage("IncreaseScore"); //スコア加算
            
        }
        
    }
}
