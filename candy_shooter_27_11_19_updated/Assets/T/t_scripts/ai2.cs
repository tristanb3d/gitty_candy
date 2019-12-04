using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ai2 : MonoBehaviour
{

    public int speed;
    // private GameObject player;  
    public NavMeshAgent agent;
    public float radius = 20f;
    private Transform target;
    public int golumHealth ;
    // Start is called before the first frame update

    private void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
         agent = gameObject.GetComponent<NavMeshAgent>();



    }

    void Update()
    {



        if (Vector3.Distance(transform.position, target.position) < radius)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
    }
    

}







////// T.B_2019