﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
//this script can be found in the Component section under the option Intro PRG/Mouse Look
//[AddComponentMenu("Intro PRG/RPG/PLAYER/Mouse Look")]
public class MouseLook : MonoBehaviour
{
    //Before you write this section please scroll to the bottom of the page
    #region Variables
    //[Header("Rotational Axis")]
    [Header("Rotational Axis")]
    //create a public link to the rotational axis called axis and set a defualt axis
    public RotationalAxis axis = RotationalAxis.MouseX;
    //[Header("Sensitivity")]
    [Header("Sensitivity")]
    //public floats for our x and y sensitivity
    [Range(0, 20)]
    public float sensitivityX = 15;
    public float sensitivityY = 15;
    //[Header("Y Rotation Clamp")]
    [Header("Y Rotation Clamp")]
    // [Header("Rotation Clamp")]
    [Header("Rotation Clamp")]
    //max and min Y rotation
    public float minY = -60;
    public float maxY = 60;
    //we will have to invert our mouse position later to calculate our mouse look correctly
    //float for rotation Y
    float rotationY = 0;
    #endregion
    #region Start
    private void Start()
    {
        //if our game object has a rigidbody attached to it
        if (this.GetComponent<Rigidbody>())
        {
            //set the rigidbodys freezRotaion to true
            this.GetComponent<Rigidbody>().freezeRotation = true;
        }

    }
    #endregion
    #region Update
    private void Update()
    {
        #region Mouse X and Y
        //if our axis is set to Mouse X and Y
        if (axis == RotationalAxis.MouseXandY)
        {
            //float rotation x is equal to our y axis plus the mouse input on the Mouse X times our x sensitivity 
            float rotationX = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * sensitivityX;
            //our rotation Y is plus equals our mouse input for Mouse Y times Y sensitivity
            rotationY += Input.GetAxis("Mouse Y") * sensitivityY;
            //the rotation Y is clamped using Mathf and we are clamping the y rotation to the Y min and Y max
            rotationY = Mathf.Clamp(rotationY, minY, maxY);
            //transform our local position to the nex vector3 rotaion - y rotaion on the x axis and x rotation on the y axis
            transform.localEulerAngles = new Vector3(-rotationY, rotationX, 0);
        }

        #endregion
        #region Mouse X
        else if (axis == RotationalAxis.MouseX)
        {
            //else if we are rotating on the X

            //transform the rotation on our game objects Y by our Mouse input Mouse X times X sensitivity
            //x                y                          z
            transform.Rotate(0, Input.GetAxis("Mouse X") * sensitivityX, 0);
        }
        #endregion
        #region Mouse Y
        //else we are only rotation on the Y
        else
        {
            //our rotation Y is pulse equals  our mouse input for Mouse Y times Y sensitivity
            rotationY += Input.GetAxis("Mouse Y") * sensitivityY;
            //the rotation Y is clamped using Mathf and we are clamping the y rotation to the Y min and Y max
            rotationY = Mathf.Clamp(rotationY, minY, maxY);
            //transform our local position to the nex vector3 rotaion - y rotaion on the x axis and local euler angle Y on the y axis
            transform.localEulerAngles = new Vector3(-rotationY, transform.localEulerAngles.y, 0);
        }
        #endregion

    }

    #endregion
}
#region RotationalAxis
/*
enums are what we call state value variables 
they are comma separated lists of identifiers
we can use them to create Type or Category variables
meaning each heading of the list is a type or category element that this can be
eg weapons in an inventory are a type of inventory item
if the item is a weapon we can equipt it
if it is a consumable we can drink it
it runs different code depending on what that objects enum is set to
you can also have subtypes within those types
eg weapons are an inventory category or type
we can then have ranged, melee weapons
or daggers, short swords, long swords, mace, axe, great axe, war axe and so on
each Type or Category holds different infomation the game needs like 
what animation plays, where the hands sit on the weapon, how many hands sit on the weapon and so on
*/
//Create a public enum called RotationalAxis
public enum RotationalAxis
{
    MouseXandY = 0,
    MouseX,
    MouseY
}
//Creating an enum out side the script and making it public means it can be asessed anywhere in any script with out reference
#endregion









//// T.B_2019