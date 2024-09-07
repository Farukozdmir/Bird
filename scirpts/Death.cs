using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour

{
    public text2 textt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other) 
    {
        Time.timeScale = 0;
        textt.gameoverr();
    }
}
