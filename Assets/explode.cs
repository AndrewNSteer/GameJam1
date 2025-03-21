using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explode : MonoBehaviour
{
    float timer = 0f;
    float timeToDestroy = 0.3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DestroyEx();
    }

    void DestroyEx(){
        if (timer > timeToDestroy){
            Destroy(gameObject);
        }
        else{ 
            timer += Time.deltaTime;
        }
    }
}
