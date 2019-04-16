using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ShipLife : MonoBehaviour
{
    const int DefaultLife = 3; //HP
    public static int life = DefaultLife;
    public string gameOver = "GoGameOver";
    public Text Warning;
    AudioSource audioSource;

    public AudioClip audioClip;
    

    public int Life()
    {
        
        return life;
        
    }

    // Use this for initialization
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>(); //AudioSource内のドラッグ＆ドロップしたSEやBGMを参照
        audioSource.clip = audioClip;

        Warning.gameObject.SetActive(false);


    

    }

    // Update is called once per frame
    void Update()
    {
        
        if (life <= 0)
        {
           
            //  SceneManager.LoadScene("GameOver");
            Invoke(gameOver, 3.5f); //gameOverはString型で定義されているため、エディタ上で変えるだけで行き先を変更可能
        }

        if (life == 1)
        {
            Warning.gameObject.SetActive(true);
        }
        else if (life != 1)
        {
            Warning.gameObject.SetActive(false);
        }

        if (life > 3)
        {
            life = 3;
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "enemy") //enemyのtagを持つものが当たった時のみダメージを食らう
        {
            
            life--;
            audioSource.Play();
            
          
            Camera.main.SendMessage("Clash"); //カメラを揺らす ClashCameraスクリプト内のClash関数を呼び出している
        }

    }

    public void GoGameOver() //↓難易度ごとにゲームオーバーの行き先を変えるための関数。上で使う
    {
        SceneManager.LoadScene("GameOver");
    }

    public void GoGameOver1()
    {
        SceneManager.LoadScene("GameOverEasy");
    }

    public void GoGameOver2()
    {
        SceneManager.LoadScene("GameOverMedium");
    }

    public void GoGameOverHidden()
    {
        SceneManager.LoadScene("GameOverHidden");
    }
}