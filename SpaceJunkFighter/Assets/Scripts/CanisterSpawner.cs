using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanisterSpawner : MonoBehaviour
{
    public GameObject empty;
    public GameObject canister;
    public int rows;
    public int columns;
    public int spacing;
    public List<GameObject> spawnZones;
    public float canTimer;

    private Vector3 instancePos = new Vector3(0.0f, 0.0f, 0.0f);


    // Start is called before the first frame update
    void Start()
    {
        spawnZones = new List<GameObject>();

        for (int r = 0; r < rows; r++)
        {
            instancePos.z = 0;
            instancePos.x += spacing;
            for (int c = 1; c < columns + 1; c++)
            {
                GameObject tRefGO = Instantiate(empty);
                instancePos.z = spacing * c;
                empty.transform.position = instancePos;
                spawnZones.Add(tRefGO);
            }
        }

        Invoke("SpawnCanister", 3f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnCanister()
    {
        GameObject tCan = Instantiate<GameObject>(canister);
        tCan.transform.position = spawnZones[Random.Range(0,spawnZones.Count)].transform.position;
        Invoke("SpawnCanister", canTimer);
    }
}
