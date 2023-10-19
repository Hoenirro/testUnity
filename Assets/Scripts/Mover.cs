using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float beamSpeed = 10.0f;
    public float duration = 5f;
    // Start is called before the first frame update
    //public Transform shine;
    //public float shineSeconds = 1.0f;
    float timer;
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(beamSpeed, 0.0f);

        StartCoroutine(DestroyAfterDuration());
    }

    // A coroutine that waits for a certain amount of seconds and then destroys the object
    IEnumerator DestroyAfterDuration()
    {
        // Wait for the duration
        yield return new WaitForSeconds(duration);

        // Destroy the object
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {

    }

    

    
}
