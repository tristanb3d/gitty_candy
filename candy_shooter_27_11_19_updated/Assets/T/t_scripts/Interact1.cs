using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Interact1 : MonoBehaviour
{
    public Animation gunani;
    public Animator ani;
    public GameObject player;
    public GameObject Cam;
    public Transform bullets;
    public Transform projectile;
    public float fireforce;
    public GameObject Gun;
    public Rigidbody prigd;
    public LineRenderer laserLineRenderer;
    public float laserWidth = 0.1f;
    public float laserMaxLength = 5f;
    // public Transform bullet;


    public Text texty;
    public int scorecount = 0;



    public void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {

            Ray shoot;

            shoot = Camera.main.ScreenPointToRay(new Vector2(Screen.width / 2, Screen.height / 2));
            //create hit info
            RaycastHit hitInfo;


            if (Physics.Raycast(shoot, out hitInfo, 100000))

                if (hitInfo.collider.CompareTag("enm"))
                {

                    scorecount += 1;
                    Debug.Log("enm");
                    //Destroy(GameObject.FindWithTag("enm"));
                    Destroy(hitInfo.collider.gameObject);
                    texty.text = "Score:  " + scorecount;


                }







        }
    }
}




//// T.B_2019




