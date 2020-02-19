using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandRotCanister : MonoBehaviour
{
    public static float bottomZ = -20f;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 startRot = new Vector3(Random.Range(0.0f, 360.0f), (Random.Range(0.0f, 360.0f)), (Random.Range(0.0f, 360.0f)));
        transform.Rotate(startRot);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
        
        if (transform.position.z < bottomZ)
        {
            Destroy(this.gameObject);

            Spaceship spaceship = Camera.main.GetComponent<Spaceship>();
            spaceship.JunkFell();
        }
    }
}
