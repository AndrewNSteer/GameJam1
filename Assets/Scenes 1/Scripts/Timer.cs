using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float targetTime = 60;
    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(Countdown());
    }


    // Update is called once per frame
    void Update()
    {
       
        if(targetTime <= 0)
        {
            TimerEnded();

        }
        else{
            targetTime -= Time.deltaTime;
        }
    }

    void TimerEnded()
    {
        print("Worked");
            SceneManager.LoadScene("GameOver");
    }
}
