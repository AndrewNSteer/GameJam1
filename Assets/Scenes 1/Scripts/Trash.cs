using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed = 100f;
    

    void Awake(){
        rb = GetComponent<Rigidbody2D>();
        
        transform.Rotate(0.0f, 0.0f, Random.Range(0.0f, 360.0f));
        
    }
    void Start(){
        rb.AddForce(rb.transform.up * speed);
    }

    
}
