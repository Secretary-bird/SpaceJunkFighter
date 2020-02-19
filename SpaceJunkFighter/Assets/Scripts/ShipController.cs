using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShipController : MonoBehaviour
{
    public Text scoreGT;
    public GameObject laser;
    public GameObject reticle;

    private bool canFire = true;
    
    // Start is called before the first frame update
    void Start()
    {
        GameObject scoreGO = GameObject.Find("ScoreCounter");
        scoreGT = scoreGO.GetComponent<Text>();
        scoreGT.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        //Get Current mouse screen position
        Vector3 mousePos2D = Input.mousePosition;
        mousePos2D.z = -Camera.main.transform.position.z;

        //CameraZ pos sets how far to push mouse
        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);

        //Convert 2d into 3d space
        Vector3 pos = this.transform.position;

        //Move X of Basket to Mouse X
        pos.x = mousePos3D.x;
        pos.y = mousePos3D.y;
        this.transform.position = pos;

        if (Input.GetMouseButtonDown(0))
        {
            if (canFire == true)
            {
                Instantiate(laser, reticle.transform);
                canFire = false;
            }
        } 
        else if (Input.GetMouseButtonUp(0))
        {
            canFire = true;
        }
    }

    void OnCollisionEnter(Collision coll)
    {
        GameObject collidedWith = coll.gameObject;
        //What Hit Basket
        if (collidedWith.tag == "Obstacle")
        {
            Spaceship spaceship = Camera.main.GetComponent<Spaceship>();
            spaceship.JunkFell();
        }

    }
}
