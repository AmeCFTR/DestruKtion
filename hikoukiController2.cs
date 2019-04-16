using UnityEngine; 
using System.Collections;
public class hikoukiController2 : MonoBehaviour { 

    public float speed = 5;
     void Update()
    {
     float x = Input.GetAxisRaw("Horizontal");
     float y = Input.GetAxisRaw("Vertical");
        Vector2 direction = new Vector2(x, y).normalized;
      // rigidbody2D.velocity = direction * speed;
             } 
 }
