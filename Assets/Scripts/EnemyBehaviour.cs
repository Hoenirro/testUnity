using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public int liveCounter = 5;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other){
        

        Destroy(gameObject);
        if (liveCounter <= 0){
            Destroy(other.gameObject);
        }
    }
}
