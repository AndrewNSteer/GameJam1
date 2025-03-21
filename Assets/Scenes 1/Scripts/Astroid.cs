using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Astroid : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 100f;
    

    void Awake(){
        rb = GetComponent<Rigidbody2D>();
    }
    void Start(){
        rb.AddForce(rb.transform.up * speed);
    }

    void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            //UnityEngine.SceneManagement.SceneManager.LoadScene();
            collision.gameObject.GetComponent<ShipHealth>().DealDamage();

            
        }
    }
}