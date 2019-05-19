using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private CharacterController2D controller;
    [SerializeField] private Animator animator;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private BoxCollider2D bc; 
    [SerializeField] float runSpeed = 40f;
    bool jump = false;
    bool crouch = false;
    float horizontalMove = 0f;

    public CharacterController2D Controller { get => controller; set => controller = value; }
    public Rigidbody2D Rb { get => rb; set => rb = value; }
    public Animator Animator { get => animator; set => animator = value; }
    public BoxCollider2D Bc { get => bc; set => bc = value; }

    // Update is called once per frame
    void Update()
    {
        // Pressing A and D will give a value of -1 and +1 respectively. 
        // Since it would be really slow moving 1 unit at a time, we multiply by a run speed.
        // Can later be changed to utilize walkSpeed when only A or D is pressed then use runSpeed when a key like shift is pressed.
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        // If we press Space or W or Up Arrow, the character will jump.
        if(Input.GetButtonDown("Jump")) {
            jump = true;
            // Make sure our animation plays by setting the boolean related to the jump animation to true.
            animator.SetBool("IsJumping", true);
        } else if (Input.GetButtonUp("Jump")) {
            // We want to stop jumping as soon as the button for jump has been let go of by the player.
            // By doing it this way, we allow the player to jump on the first available frame if they keep spacebar held down.
            // Having it this way means we need to drop JumpForce from 700 to 300 or the player can jump really high.
            jump = false;
            animator.SetBool("IsJumping", false);
        }

        // If we press S or Down Arrow, the character will crouch.
        if(Input.GetButtonDown("Crouch")) {
            crouch = true;
            // Make sure our animation plays by setting the boolean related to the jump animation to true.
            animator.SetBool("IsCrouching", true);
        } else if (Input.GetButtonUp("Crouch")) {
            // We want to stop crouching as soon as the button for crouch has been let go of by the player.
            crouch = false;
            animator.SetBool("IsCrouching", false);
        }

        if(bc.isActiveAndEnabled)
        {
            // Crouching is a special case because the character controller will stop a player from uncrouching if they are under an obstacle.
            // The character controller will allow the box collider on the character to be enabled as long as the player is crouching and/or
            // if the player is NOT under an obstacle where standing up is not possible.
            animator.SetBool("IsCrouching", false);
        } else
        {
            animator.SetBool("IsCrouching", true);
        }

        // To make sure that we don't slide off the surface of a slope when not moving.
        if(horizontalMove == 0f)
        {
            // We don't freeze y because then we'll get stuck in the air when the player let's go of A or D.
            rb.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezeRotation;
        } else {
            // We want to make sure to keep rotation frozen or the player will just fall over and wont be able to get back up.
            rb.constraints = RigidbodyConstraints2D.None | RigidbodyConstraints2D.FreezeRotation;
        }
    }

    void FixedUpdate()
    {
        // Multiplying by Time.fixedDeltaTime ensures that we move the same amount no matter how many times this function is called.
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);

        // Legacy: turning jump off like this instead of how crouch is turned off 
        // makes it so that you can't hold down space to automatically jump on the frame that the character is able.
        //jump = false;
    }

    // Legacy: for some reason, the character controller will not call this event.
    // This function will get called by the callback function (event)
    // Set this up by going to the CharacterController2D script then in the Events section click on the plus sign under On Land Event ().
    // Drag and drop this script onto the place that says "None (Object)" then select this function.
    public void OnLanding()
    {
        animator.SetBool("IsJumping", false);
    }


    // Legacy: for some reason, the character controller will not call this event.
    // This function will get called by the callback function (event)
    // This is setup in the same way as the OnLanding() function just put it in the On Crouch Event (Boolean).
    public void OnCrouching(bool isCrouching)
    {
        animator.SetBool("IsCrouching", isCrouching);
    }
}