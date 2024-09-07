using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dia : MonoBehaviour

{
    public GameObject go;
    public score scores;
    public square squarescale;
    
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        scores.Updatescore();
        squarescale.scaleplus();
        Vector2 pos = new Vector2 (Random.Range(-2,2),Random.Range(-3,4));
        Instantiate (go,pos,transform.rotation);
        Destroy(this.gameObject);
        
        
    }
}
