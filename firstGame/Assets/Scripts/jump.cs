using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    public float jumpSpeed = 5;
    private Rigidbody rigidBody;
    private bool onGround = true;
    public int currentJump = 0;
    public int maxJump = 3;
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    
    void Update()
    { 
        if (Input.GetKeyDown("space") && (onGround || maxJump > currentJump))
        {
            rigidBody.AddForce(Vector3.up * jumpSpeed, ForceMode.Impulse);
            onGround = false;
            currentJump++;
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        onGround = true;
        currentJump = 0;
    }
}
