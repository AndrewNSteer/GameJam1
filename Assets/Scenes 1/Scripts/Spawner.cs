using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject[] asteroids;
    bool Spawn = true;

    IEnumerator SpawnRoid(){
        while(Spawn){
            var roid = Instantiate(asteroids[Random.Range(0, asteroids.Length)], transform.position, transform.rotation);
        yield return new WaitForSeconds(1);
        }
        
    }

    // Start is called before the first frame update
    void Start()
    {
         StartCoroutine(SpawnRoid());
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
