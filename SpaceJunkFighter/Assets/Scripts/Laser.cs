using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Laser : MonoBehaviour
{
    
 
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
        //What Hit Laser
        if (collidedWith.tag == "Obstacle")
        {
            Destroy(collidedWith);
 /*           Spaceship spaceship = Camera.main.GetComponent<Spaceship>();
            spaceship.addScore();*/
        }

    }

    void Destroy()
    {
        Destroy(gameObject);
    }
}

