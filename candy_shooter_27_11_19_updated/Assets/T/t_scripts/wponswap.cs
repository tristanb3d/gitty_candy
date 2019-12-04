using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wponswap : MonoBehaviour
{
    public GameObject pistol;
    public GameObject shotgun;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))

        {
            //weaponSwitch();
            pistol1();
        }

        if (Input.GetKeyDown(KeyCode.E))

        {
            shotgun1();
        }
    }



    public void pistol1()
    {
        shotgun.gameObject.SetActive(false);
        pistol.gameObject.SetActive(true);
        
    }

    public void shotgun1()
    {
        pistol.gameObject.SetActive(false);
        shotgun.gameObject.SetActive(true);
    }
    //    public void weaponSwitch()
    //    {

    //        pistol.gameObject.SetActive(true);
    //        shotgun.gameObject.SetActive(false);

    //        if (pistol.gameObject.SetActive(true))
    //        {

    //            shotgun.gameObject.SetActive (false);
    //        }

    //        else



    //    if  (shotgun.gameObject.SetActive( true))
    //        {

    //            pistol.gameObject.SetActive (false);
    //        }

    //    }
}