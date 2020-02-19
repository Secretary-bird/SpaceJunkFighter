using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spaceship : MonoBehaviour
{
    public int lives = 3;
    public GameObject Ship;

    // Start is called before the first frame update
    void Start()
    {
        
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
            SceneManager.LoadScene("_Scene_0");
        }
    }
}
