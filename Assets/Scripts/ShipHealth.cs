using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShipHealth : MonoBehaviour{
    [SerializeField] public float health;
    SpriteRenderer spr;
    public Sprite dmg1;
    public Sprite dmg2;
    public Sprite dmg3;

    public void Awake(){
        health = 3;
    }

    void Start(){
        spr = GetComponent<SpriteRenderer>();
    }

    public void DealDamage(){
        health--;
    }

    void Update(){
        switch(health){
            case (3):
                spr.sprite = dmg1;
                break;
            case (2):
                spr.sprite = dmg2;
                break;
            case (1):
                spr.sprite = dmg3;
                break;
            case (0):
                Destroy(gameObject);
                SceneManager.LoadScene("GameOver");
                break;
        }
    }
}
