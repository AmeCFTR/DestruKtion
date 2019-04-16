using System.Collections;
using UnityEngine;

public class ScrollObject : MonoBehaviour { //ゲームオブジェクトが横に動く.
    public float speed = 1.0f;
    public float startPosition;
    public float endPosition;

    void Start()
    {
        
       
    }
    void Update() {
        transform.Translate(-1 * speed * Time.deltaTime, 0, 0); 
        if (transform.position.x <= endPosition) ScrollEnd();
    }
    void ScrollEnd()
    {
        transform.Translate(-1 * (endPosition - startPosition), 0, 0);
        SendMessage("OnScrollEnd", SendMessageOptions.DontRequireReceiver);
    }
    
	}

