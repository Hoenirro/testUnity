using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBycontact : MonoBehaviour
{

    public GameObject bigExplosion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

private void OnCollisionEnter2D(Collision2D other){

        Instantiate(bigExplosion, transform.position, transform.rotation);


        Destroy(other.gameObject);
        Destroy(this.gameObject);
}

}
