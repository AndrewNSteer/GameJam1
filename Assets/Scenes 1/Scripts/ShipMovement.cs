using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    //public float speed;
    public float horizontal;
    public float vertical;
    Rigidbody2D playerRigidbody;
    [SerializeField] float moveSpeed = 3f;

    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal"); 
        vertical = Input.GetAxis("Vertical"); 

        
        //Vector2 ShipMovement = new Vector2 
    }
    

    void FixedUpdate()
    {
        playerRigidbody.velocity = new Vector2(horizontal * moveSpeed, vertical * moveSpeed);
    }
}

