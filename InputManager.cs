using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InputManager : MonoBehaviour {

    InputField inputField;
    public static Text text; //テキストの中身共有用

    public static int i;

	// Use this for initialization
	void Start () {
        inputField = GetComponent<InputField>();
        text = GameObject.Find("Text").GetComponent<Text>(); 
        InitInputField();
	}
	
	// Update is called once per frame
	void Update () {
        Invoke("GoTitle", 8);
	}

    public void InputLogger()
    {
        string inputValue = inputField.text;
         i = int.Parse(inputValue);
        Debug.Log(inputValue); //Enterキーを押したとき、ここに保存される
        InitInputField();
    }


    void InitInputField()
    {
        text.text = inputField.text;
        Debug.Log(text.text);

        inputField.text = ""; //中身をリセット
        inputField.ActivateInputField();//フォーカス

    }

    void GoTitle()
    {
        SceneManager.LoadScene("Title");
    }
}
