using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    float magnitude = 1f;
    public GameObject Beam;
    //public GameObject StartBeam;
    //public GameObject Spawner;

    private Rigidbody2D nerigidbody2D;

    public float minX, maxX, minY, maxY;

    // Start is called before the first frame update
    void Start()
    {
        nerigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalMovement;
        float verticalMovement;

        horizontalMovement = Input.GetAxis("Horizontal");
        verticalMovement = Input.GetAxis("Vertical");

        //Debug.Log("Horizontal: " + horizontalMovement + ", Vertical: " + verticalMovement);

        Vector2 newVelocity = new Vector2(horizontalMovement, verticalMovement);
        GetComponent<Rigidbody2D>().velocity = newVelocity * magnitude;
        //Debug.Log("Vector: " + GetComponent<Rigidbody2D>().velocity);

        float newX, newY;

        newX = Mathf.Clamp(GetComponent<Rigidbody2D>().position.x, minX, maxX);
        newY = Mathf.Clamp(GetComponent<Rigidbody2D>().position.y, minY, maxY);

        GetComponent<Rigidbody2D>().position = new Vector2(newX, newY);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Instantiate the prefab at the same position and rotation as the object
            Instantiate(Beam, transform.position, transform.rotation);
            //Instantiate(StartBeam, transform.position, transform.rotation);
        }


    }
}
