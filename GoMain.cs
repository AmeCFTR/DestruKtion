using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GoMain : MonoBehaviour
{
    public Text HighScoreLabel;
    public Text HighScoreEasyLabel;
    public Text HighScoreMediumLabel;
    public Text HighScoreHiddenLabel;

    public static Text Test;
    GameObject CatchName;

    public AudioClip audioClip;
    AudioSource audioSource;

    // Use this for initialization
    
   public void Start()
    {
       // CatchName.GetComponent<InputManager>();
    

        HighScoreLabel.text = "Extreme Top Score : " + PlayerPrefs.GetInt("HighScore");
        HighScoreEasyLabel.text = "Easy Top Score : " + PlayerPrefs.GetInt("HighScoreEasy");
        HighScoreMediumLabel.text = "Medium Top Score : " + PlayerPrefs.GetInt("HighScoreMedium");
        HighScoreHiddenLabel.text = "Hidden Top Score : " + PlayerPrefs.GetInt("HighScoreHidden");

       // Test = "" + InputManager.i; //エラーが出てる

        audioSource = gameObject.GetComponent<AudioSource>(); //AudioSource内のドラッグ＆ドロップしたSEやBGMを参照
        audioSource.clip = audioClip;
    }


    // Update is called once per frame
    void Update()
    {

    }


    public void OnStartButtonClicked()
    {
        audioSource.Play();
        Invoke("GoDifficulty", 0.49f);
        
    }

    public void GoDifficulty()
    {
        SceneManager.LoadScene("choose difficulty");
    }
}