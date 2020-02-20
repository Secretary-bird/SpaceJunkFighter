using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    public Text scoreGT;
    private bool alive = true;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Awake()
    {
        GameObject scoreGO = GameObject.Find("ScoreHandler");
        scoreGT = scoreGO.GetComponent<Text>();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Spaceship jeff = Camera.main.GetComponent<Spaceship>();
        if (alive == true)
        {
            scoreGT.text = ("Lives: " + jeff.lives);
            if (jeff.lives == 0)
            {
                isDead();
            }
        }
        
    }

    void isDead()
    {
        Spaceship jeff = Camera.main.GetComponent<Spaceship>();
        
            alive = false;
            scoreGT.text = ("YOU DIED");
            GameObject junk = GameObject.Find("JunkHandler");
            Destroy(junk);
            GameObject ship = GameObject.Find("Ship 1");
            Destroy(ship);
        
    }
}
