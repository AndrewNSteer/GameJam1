using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletVel : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 1f;

    // Start is called before the first frame update
    void Awake(){
        rb = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        
        rb.AddForce(rb.transform.up * speed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
