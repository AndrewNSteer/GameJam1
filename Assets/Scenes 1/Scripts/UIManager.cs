using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class UIManager : MonoBehaviour
{   
    public TextMeshProUGUI timerText;
    public Timer timer;

    public void BackToStart()
    {
        SceneManager.LoadScene("Level1");
    }

    public void MMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int time = (int)timer.targetTime;
        timerText.text = time.ToString();
    }
}
