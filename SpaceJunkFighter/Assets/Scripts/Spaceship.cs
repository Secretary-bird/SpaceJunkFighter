using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Spaceship : MonoBehaviour
{
    public int lives = 3;
    public GameObject Ship;
    public Text scoreGT;
    private int score = 1000;

    // Start is called before the first frame update
    void Start()
    {
        GameObject scoreGO = GameObject.Find("ScoreCounter");
        scoreGT = scoreGO.GetComponent<Text>();
        //scoreGT.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void JunkFell()
    {
        GameObject[] tJunkArray = GameObject.FindGameObjectsWithTag("Obstacle");
        foreach (GameObject tGO in tJunkArray)
        {
            Destroy(tGO);
        }

        lives--;

        if (lives == 0)
        {
            //SceneManager.LoadScene("_Scene_0");
        }
    }

/* public void addScore()
    {
        int score = int.Parse(scoreGT.text);
        score += 100;
        scoreGT.text = score.ToString();

        if (score > HighScore.score)
        {
            HighScore.score = score;
        }
    }*/
}
