using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private CharacterController2D controller;
    [SerializeField] float runSpeed = 40f;
    bool jump = false;
    bool crouch = false;
    float horizontalMove = 0f;

    public CharacterController2D Controller { get => controller; set => controller = value; }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        if(Input.GetButtonDown("Jump")) { jump = true; }
        if (Input.GetButtonDown("Crouch")) { crouch = true; }
        else if (Input.GetButtonUp("Crouch")) { crouch = false; }
        Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        // Multiplying by Time.fixedDeltaTime ensures that we move the same amount no matter how many times this function is called.
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }
}