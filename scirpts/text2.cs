using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class text2 : MonoBehaviour

{
    public Text textover;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void gameoverr()
    {
        textover.text = "Game\nOver";
    }
    public void retry()
    {
        textover.text = "";
    }
}
