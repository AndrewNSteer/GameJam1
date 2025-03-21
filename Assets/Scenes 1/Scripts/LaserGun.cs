using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserGun : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    public float bulletSpeed = 300.0f;
    public float offsetX = 0.7f;
    public float offsetY = 0;
    //public Rigidbody2D rb;
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            FireWeapon();
        }
    }

    void FireWeapon()
    {
        
        var shot = Instantiate(bullet, transform.position, transform.rotation);
        Destroy(shot, 5f); 
        //shot.velocity = transform.forward * bulletSpeed;  
    }
}
