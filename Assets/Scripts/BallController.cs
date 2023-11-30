using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    
    Rigidbody rb;
    public float speed;
    private float inputX, inputY;
    bool Move = false; 

    
    void Start()
    {
        rb.velocity = new Vector3(0, 0, speed);
        
        if (Input.GetButtonDown("Fire2"))
        {
            Move = true;
        }
        
    }
    
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }


    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    private void FixedUpdate()
    { 
        
        rb.velocity = new Vector3(inputX* speed, rb.velocity.y,inputY * speed);
        

    }

    void Movement()
    {
        inputX = Input.GetAxis("Horizontal");
        inputY = Input.GetAxis("Vertical");

    }
}
