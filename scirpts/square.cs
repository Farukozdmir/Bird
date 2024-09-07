using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class square : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public float velocity;
    
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("w"))
        {
            rb2d.velocity = Vector2.up * velocity;
        }
        
        if(Input.GetKey("a"))
        {
            rb2d.velocity = Vector2.left * velocity;
        }
        
        if(Input.GetKey("d"))
        {
            rb2d.velocity = Vector2.right * velocity;
        }
        
        if(Input.GetKey("s"))
        {
            rb2d.velocity = Vector2.down * velocity;
        }
        
    }

    public void scaleplus()
    {
        velocity += 0.1f;
    }

    public void relocate()
    {
        velocity = 2;
        transform.position = new Vector2(0,0);
        

    }

    
}
