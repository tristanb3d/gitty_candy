using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balllon_AI : MonoBehaviour
{
   // public GameObject plyer;
    //public GameObject Player;
    //move to position 
    public Vector3 vec3;
    public float movespeed = 5f;
   private Transform target;

    private void Start()
    {

        target = GameObject.FindGameObjectWithTag("Player").transform;
        vec3 = transform.position - target.transform.position;
    }

    void Update()
    {
        transform.LookAt(target.transform);
        transform.position += transform.forward * movespeed * Time.deltaTime;

    }



    //do  damage 
    //colider 
    //
    //Destroy(col.gameObject);

    void OnTriggerEnter(Collider coli)
    {
        //do dammage 
        if (coli.gameObject.CompareTag("Player"))
        {
            //Destroy(Player);
            Debug.Log("B_loon_hito");

        }
  
    }

}



