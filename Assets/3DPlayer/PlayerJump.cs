using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    [SerializeField] private float jumpForce;

    [SerializeField] private Transform groundCheck;

    [SerializeField] private LayerMask groundLayer;

    private Rigidbody rb;

    private bool canJump;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        bool grounded = Physics.Linecast(transform.position, groundCheck.position, groundLayer);

        if (grounded == true)
            canJump = true;
        else
            canJump = false;

        Jump();
    }

    private void Jump()
    {
        if (Input.GetButtonDown("Jump") && canJump == true)
        {
            canJump = false;
            rb.AddForce(Vector3.up * jumpForce);
        }
    }
}