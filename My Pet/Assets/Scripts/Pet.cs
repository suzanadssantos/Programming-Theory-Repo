using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pet : MonoBehaviour
{
    public Rigidbody rb;
    public float runSpeed = 1.0f;
    public float turnSpeed = 1.0f;
    public float jumpForce = 0.5f;
    public bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Run(){
        float horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(runSpeed * Time.deltaTime * Vector3.forward);
        transform.Rotate(turnSpeed * Time.deltaTime * horizontalInput * Vector3.up);  
    }

    public void Jump(){
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded){     
            rb.velocity = new Vector3 (rb.velocity.x,jumpForce,rb.velocity.z);
            isGrounded = false;
        }
    }

    public void OnCollisionStay(){
        isGrounded = true;
    }
}
