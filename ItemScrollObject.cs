using System.Collections;
using UnityEngine;

public class ItemScrollObject : MonoBehaviour
{
    public float speed = 1.0f;
    public float startPosition;
    public float endPoint = -5.5f;

    void Start()
    {


    }
    void Update()
    {
        transform.Translate(0, -1 * speed * Time.deltaTime, 0);
        if (transform.position.y <= endPoint)
        {
            Destroy(this.gameObject);
        }
    }
    

}
