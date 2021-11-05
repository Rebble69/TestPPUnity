using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovemtn : MonoBehaviour
{
    [Header("Assignment Stuff")] 
    public GameObject playerBody;

    [Header("MovementValues")] 
    public float moveSpeed = 12f;

    //Private Var's
    private Rigidbody rb;
    private GameObject playerCapsule;
    private Vector3 moveDirection;
    private float movementMulti = 0.01f;
    
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        rb = playerBody.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        InputHandler();   
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }

    void InputHandler()
    {
        var x = Input.GetAxisRaw("Horizontal");
        var y = Input.GetAxisRaw("Vertical");

        moveDirection = transform.forward * y + transform.right * x;
    }

    void MovePlayer()
    {
        rb.AddForce(moveDirection.normalized * moveSpeed * movementMulti, ForceMode.Impulse);
    }
    
}
