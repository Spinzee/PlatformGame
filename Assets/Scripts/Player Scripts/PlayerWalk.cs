using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalk : MonoBehaviour
{
    [SerializeField] AudioClip DeathSound;

    private readonly float speed = 10f;
    private readonly float jumpForce = 130f;

    private Rigidbody playerRB;
    private Animator anim;

    private bool isOnGround = true;
    private float horizontalInput;
    private bool isFacingRight = true;
    private AudioSource audio;

    void Awake()
    {
        playerRB = GetComponent<Rigidbody>();
        anim = gameObject.GetComponentInChildren<Animator>();
        audio = gameObject.GetComponentInChildren<AudioSource>();
    }

    // TODO change to a fixed update
    void Update()
    {
        if (GameplayController.Instance.GameIsActive)
        {
            Walk();
            Jump();
        }
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

            // TODO work out why the jump animation is making the player position go funky
            //anim.SetBool("Jump_b", true);
        }
    }

    // TODO change this to a trigger
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
            //anim.SetBool("Jump_b", false);
        }
        else if (collision.gameObject.CompareTag("Enemy"))
        {
            audio.PlayOneShot(DeathSound, 0.5f);
            anim.SetBool("Death_b", true);
            GameplayController.Instance.DecrementLife();
        }
        else if (collision.gameObject.CompareTag("Finish"))
        {
            anim.SetFloat("Speed_f", 0f);
            anim.SetInteger("WeaponType_int", 10);
            GameplayController.Instance.PlayerFinished();
        }
    }
}
