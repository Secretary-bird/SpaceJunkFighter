using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanisterSpawner : MonoBehaviour
{
    public GameObject canister;
    public float canTimer;

    private Vector3 instancePos = new Vector3(-20.0f, -10.0f, 20.0f);


    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnCanister", 3f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnCanister()
    {
        Vector3 pos = new Vector3(Random.Range(-10f, 10f), Random.Range(-5f, 5f), 20f);
        Instantiate(canister, pos, Quaternion.identity);
        
        Invoke("SpawnCanister", canTimer);
    }
}
