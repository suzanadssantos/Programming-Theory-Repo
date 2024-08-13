using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Dog : Pet
{
    public TextMeshProUGUI petNameText;

    // Start is called before the first frame update
    void Start()
    { 
        jumpForce = 3.5f;
        turnSpeed = 14.0f;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Run();
        Jump();
        Talk();
    }

    public override void Run(){
        float horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(2.0f * Time.deltaTime * Vector3.forward);
        transform.Rotate(turnSpeed * Time.deltaTime * horizontalInput * Vector3.up);  
    }
}