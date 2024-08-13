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
        runSpeed = 2.0f;
        turnSpeed = 14.0f;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Run();
        Jump();
    }
}