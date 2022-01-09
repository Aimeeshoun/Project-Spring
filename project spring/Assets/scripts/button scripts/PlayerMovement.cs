using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(CharacterController))]
public class PlayerMovement : MonoBehaviour


{
    public int normalSpeed = 20;
    public float jumpMax = 3;
    private Vector3 movement;
    private float gravity = 0f;
    public float thePlayerSpeed;
    public CharacterController myController;
    public float rotatespeed = 10f;
    public int playerJumpCount;
    public IntData JumpCountMax;
    private float yVar;
    private void Start()
    {
        thePlayerSpeed = normalSpeed;
        myController = GetComponent<CharacterController>();
    }
    void Update()
    {
        var hInput = Input.GetAxis("Horizontal") * Time.deltaTime * rotatespeed;
        transform.Rotate(0, hInput, 0);
        var vInput = Input.GetAxis("Vertical") * thePlayerSpeed;
        movement.Set(vInput, yVar, 0);
        yVar += gravity * Time.deltaTime;

        if (myController.isGrounded && movement.y < 0)
        {
            yVar = -1f;
            playerJumpCount = 0;
        }
        if (Input.GetKeyDown(KeyCode.J) && playerJumpCount < JumpCountMax.value)
        {
            yVar = jumpMax;
            playerJumpCount++;
        }
        movement = transform.TransformDirection(movement);
        myController.Move(movement * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.J) && myController.isGrounded)
        {
            movement.y = jumpMax;
        }
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        myController.Move(move * Time.deltaTime * thePlayerSpeed);


        {
            gameObject.transform.forward = move;
        }
        movement.y += gravity * Time.deltaTime;
        myController.Move(movement * Time.deltaTime);
    }
}
