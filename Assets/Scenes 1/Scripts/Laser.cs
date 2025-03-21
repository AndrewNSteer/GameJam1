using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public string targetTag = "Target";
    public GameObject Explode;
    public Transform ExTran;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(targetTag))
        {
            //Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Target")
        {
            Instantiate(Explode, ExTran.position, ExTran.rotation);
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
