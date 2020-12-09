using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalk : MonoBehaviour
{
    private readonly float speed = 10f;
    private readonly float jumpForce = 130f;

    private Rigidbody playerRB;
    private Animator anim;

    private bool isOnGround = true;
    private float horizontalInput;
    private bool isFacingRight = true;

    void Awake()
    {
        playerRB = GetComponent<Rigidbody>();
        //anim = GetComponent<Animator>();
    }

    // TODO change to a fixed update
    void Update()
    {
        Walk();
        Jump();
    }

    private void Walk()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");

        if ((horizontalInput > 0 && !isFacingRight) || (horizontalInput < 0 && isFacingRight))
        {
            Flip();
        }

        if (horizontalInput == 0)
        {
            //anim.SetBool("Walk", false);
        }
        else
        {
            //vector3.forward is relative to players direction so i don't want to use it            
            transform.Translate(horizontalInput * speed * Time.deltaTime, 0, 0, Space.World);
            //anim.SetBool("Walk", true);
        }
    }

    private void Flip()
    {
        isFacingRight = !isFacingRight;

        transform.Rotate(0, 180, 0);
    }

    private void Jump()
    {
        if (Input.GetKey(KeyCode.UpArrow) && isOnGround)
        {
            playerRB.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
        }
    }

    // TODO change this to a trigger
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }
    }
}
