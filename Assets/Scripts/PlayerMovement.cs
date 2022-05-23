using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEditor.Build;

public class PlayerMovement : MonoBehaviour
{
    public float MovementSpeedMultiplier;

    public Rigidbody2D ObjRigidbody;

    public bool isJumping = false;

   private void Start()
    {
        ObjRigidbody = GetComponent<Rigidbody2D>();
       
    }

   private void Update()
   {
       if (Input.GetKeyDown(KeyCode.UpArrow))
       {
           isJumping = true;
       }
   }
   
   private void FixedUpdate()
    {
        float horizontalMovement = Input.GetAxis("Horizontal");
        Vector3 MovementVector = new Vector3(horizontalMovement, 0, 0);

        if (isJumping)
        {
            Vector3 JumpVector = new Vector3(0, MovementSpeedMultiplier, 0);
            
            ObjRigidbody.AddForce(JumpVector,ForceMode2D.Impulse);
            isJumping = false;
        }
        
        ObjRigidbody.AddForce(MovementVector * MovementSpeedMultiplier,ForceMode2D.Force);
        
    }
    
    
}
