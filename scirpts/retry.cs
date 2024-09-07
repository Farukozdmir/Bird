using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class retry : MonoBehaviour
{
    public square sq;
    public text2 textt;
    public Button retrybutton;
    public score sc;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = retrybutton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void TaskOnClick()
    {
		
        textt.retry();
        sq.relocate();
        sc.resetscore();
        Time.timeScale = 1;
        

	  }
    
}
