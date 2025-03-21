using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.tag == "Player"){
            Destroy(collision.gameObject);
            collision.gameObject.GetComponent<ShipHealth>().DealDamage();
            
        }
    }
}
   
