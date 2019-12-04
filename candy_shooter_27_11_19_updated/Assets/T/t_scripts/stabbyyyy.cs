using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class stabbyyyy : MonoBehaviour
{


    public void OnTriggerEnter(Collider coli)
    {
        // if(cane.SetActive(true))

        //do dammage 
        if (coli.gameObject.CompareTag("enm"))
        {
            //  Debug.Log("shoot");
            Destroy(coli.gameObject);
            //Destroy(gameObject.CompareTag("enm"));
        }

    }


}

