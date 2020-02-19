using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Laser : MonoBehaviour
{
    public Text scoreGT;
 
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Destroy", .5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision coll)
    {
        GameObject collidedWith = coll.gameObject;
        //What Hit Basket
        if (collidedWith.tag == "Obstacle")
        {
            Destroy(collidedWith);
            int score = int.Parse(scoreGT.text);
            score += 100;
            scoreGT.text = score.ToString();

            if (score > HighScore.score)
            {
                HighScore.score = score;
            }
        }

    }

    void Destroy()
    {
        Destroy(gameObject);
    }
}

