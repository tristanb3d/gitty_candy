using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shotgun : MonoBehaviour
{
    public GameObject part1;
    public GameObject part2;
    //public float firetime = 0.1f;
    //public float shoot_time = 0.5f;
    public bool can_shoot ;
    public Animator reload_anim;
    public Transform bullets;
    public Transform projectile;
    public Transform shot_pos;

    private void Start()
    {
        reload_anim = GetComponent<Animator>();
    }


    void Update ()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            shotgun_shot();
        }
    }

    public void shotgun_shot()
    {
        
            if (can_shoot == true)
            
            {
            reload_anim.SetTrigger("shoot_trig");
            part1.SetActive(true);
            part2.SetActive(true);

            bullets = Instantiate(projectile, shot_pos.position, shot_pos.rotation);
            bullets.GetComponent<Rigidbody>().AddForce(transform.forward * 2500);



           can_shoot = false;
            Destroy((bullets as Transform).gameObject, 0.3f);
            StartCoroutine(Example());
        }
       
    }
   // public void shotgun_shoot()

    IEnumerator Example()
    {
        yield return new WaitForSeconds(0.4F);

        reload_anim.ResetTrigger("shoot_trig");
        

        part1.SetActive(false);
        part2.SetActive(false);
        can_shoot = true;

        // yield return new WaitForSeconds(0.4F);

        //  reload_anim.ResetTrigger("shoot_trig");
        // can_shoot = true;

    }


}
