using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coolll : MonoBehaviour
{
    public GameObject Spawner2;
    public float SpawnTimer2 = 10f;
    public float SpawnWait2 = 0.05f;
    public float SpawnLimit2;
    public float SpawnMax;
    
    void Start()
    {
        InvokeRepeating("Spawn2", SpawnTimer2, SpawnWait2);
    }
    // Update is called once per frame
    void Spawn2()
    {
        SpawnLimit2 += 1;
        //  bool SpawnStop;
        if (SpawnLimit2 < SpawnMax)
        {
            Instantiate(Spawner2, transform.position, transform.rotation);
        }

        if (SpawnMax == SpawnLimit2)
        {
            Destroy(gameObject);
        }
    } 
}







//// T.B_2019