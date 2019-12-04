using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canstaby : MonoBehaviour
{
    public Animator staby_anim;
    public GameObject cane;
    // Start is called before the first frame update
    void Start()
    {
        //  staby_anim = GetComponent<Animator>();
    }

    void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update ()
         
    {
        //   staby_anim.SetBool("stab_b", false);

        //   cane.SetActive(false);
        if (Input.GetKeyDown(KeyCode.V))

        {
            stabby();
        }
    }

    public void stabby()
    {
      //  if (Input.GetButtonDown("Fire2"))
        //     if (Input.GetKey(KeyCode.V))
      //  {


            cane.gameObject.SetActive(true);
            staby_anim.SetTrigger("stab");
            //cane.gameObject.SetActive(true);
       // }
    }

    void OnTriggerEnter(Collider colis)
    {
      // if(cane.SetActive(true))

        //do dammage 
        if (colis.gameObject.CompareTag("enm"))
            {
            Debug.Log("stabby");
           // Destroy(gameObject);
            Destroy(colis.gameObject);
        }

    }
}
