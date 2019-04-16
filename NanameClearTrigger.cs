using System.Collections;
using UnityEngine;

public class NanameClearTrigger : MonoBehaviour
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
            Debug.Log("Don't Score");
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
            gameController.SendMessage("NanameIncreaseScore");
            Debug.Log("Send Score message");
        }

    }
}
