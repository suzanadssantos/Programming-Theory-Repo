using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Pet
{

    // Start is called before the first frame update
    void Start()
    {
        runSpeed = 2.0f;
        turnSpeed = 10.0f;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Run();
        Jump();
    }
}
