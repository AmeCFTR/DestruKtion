using System.Collections;
using UnityEngine;

public class TateScrollObject : MonoBehaviour {
    public float speed = 1.0f;
    public float startPosition;
    public float endPosition;
    public float speedUp = -1.0f;
    public float speedUpSecond = 8.0f;

    float speedCounter=0.0f;



    void Start(){


    }
    void Update(){

        speedCounter += Time.deltaTime; //8秒経つごとに早くなる
        if (speedCounter >= speedUpSecond) 
        {
            speed -= speedUp; //マイナスかけるマイナスで+(プラス)、 スピードアップ処理
            speedCounter = 0;
        }

        transform.Translate(0,1 * speed * Time.deltaTime, 0);
        if (transform.position.y <= endPosition) ScrollEnd();
    }
    void ScrollEnd()
    {
        transform.Translate(0,1 * (endPosition - startPosition), 0);
        SendMessage("OnScrollEnd", SendMessageOptions.DontRequireReceiver);
    }

}
