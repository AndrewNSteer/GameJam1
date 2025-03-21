using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    //public float speed;
    public float horizontal;
    public float vertical;
    public float turnSpeed;
    //public Camera cam;
    private Vector2 moveDirection;
    Rigidbody2D playerRigidbody;
    [SerializeField] float moveSpeed = 1f;

    public Vector3 mousePos;

    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        //ProcessInput();
        horizontal = Input.GetAxis("Horizontal"); 
        vertical = Input.GetAxis("Vertical");
        

        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 rotation = mousePos - transform.position;
        float rotZ = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotZ-90);
        //Vector2 ShipMovement = new Vector2 
    }
    // private void ProcessInput()
    // {
    //     float moveX = Input.GetAxis("Horizontal");
    //     float moveY = Input.GetAxis("Vertical");

    //     moveDirection = new Vector2(moveX, moveY).normalized;
    // }
    

    void FixedUpdate()
    {
        playerRigidbody.velocity = new Vector2(horizontal * moveSpeed, vertical * moveSpeed);
    }

}

