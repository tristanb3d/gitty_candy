using UnityEngine;
using System.Collections;
using System.Collections.Generic;


[RequireComponent(typeof(CharacterController))]
//script needs a CC on this object, to ref later, if dose not ahve a cc one will be made
public class movemofo : MonoBehaviour
{
    #region Variables
    [Header("Characters MoveDirection")]
    [Space(5)]

    //vector3 called moveDirection
    public Vector3 moveDirection;

    //we will use this to apply movement in worldspace
    //private CharacterController (https://docs.unity3d.com/ScriptReference/CharacterController.html) charC
    public CharacterController _characterController;
    [Header("PLAYER MOVEMENT")]
    //[Header("Character Variables")]
    //public float variables jumpSpeed, speed, gravity
    public float jumpSpeed = 14;
    public float speed = 25;
    public float gravity = 18;
    ////// or write itlike public float

    #endregion

    #region Start
   
    private void Start()
    {
        _characterController = this.GetComponent<CharacterController>();
    }
    #endregion
    #region Update


    public void LateUpdate ()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 35;
        }
      else
      {
          speed = 20;
       }
    }
    private void Update()
    {
        if (_characterController.isGrounded)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
         
            moveDirection = transform.TransformDirection(moveDirection);
       
            moveDirection *= speed;

            if (Input.GetButton("Jump"))
            {

                moveDirection.y = jumpSpeed;
            }

           
            
            

        }
     
        moveDirection.y -= gravity * Time.deltaTime;
   
        _characterController.Move(moveDirection * Time.deltaTime);
        #endregion


    }
}



//// T.B_2019