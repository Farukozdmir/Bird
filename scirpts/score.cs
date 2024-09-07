using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    private int i;
    public Text scoretext;
    // Start is called before the first frame update
    void Start()
    {
        scoretext.text = "0";
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Updatescore()
    {
        i++;
        scoretext.text = i.ToString();
    }

    public void resetscore()
    {   
        i = 0;
        scoretext.text = "0";
    }    
}
