using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed=10; //player's speed
    private Vector3 move; //player is moving by this vector

    public CharacterController controller;

    public float gravity = -10; //by Y down
    public float JumpHeight=5; //jump force
    private Vector3 velocity;//speed притягнення вниз
    private bool isGrounded; //check if we are on the ground
    public Transform GroundCheck; //where our feet are
    public LayerMask groundLayer; //layer of ground

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(speed);
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal"); //left/right
        float z = Input.GetAxis("Vertical"); //back/forth

        move = transform.right*x + transform.forward*z * 1; //move programming
        controller.Move(move*speed * Time.deltaTime); //Vector + our moves

        isGrounded=Physics.CheckSphere(GroundCheck.position, 0.1f, groundLayer);

        if(isGrounded && velocity.y <0)
        {
            velocity.y= -1f;
        }
        //Debug.Log(isGrounded); //true || false
        if(isGrounded)
        {
            if(Input.GetButtonDown("Jump"))
            {
                Jump();
            }
           else
            {
                velocity.y+=gravity*Time.deltaTime; //гравітація
            }
            
        }
         
         
        
        controller.Move(velocity * Time.deltaTime); //рух по y
    }

    private void Jump()
    {
        velocity.y=Mathf.Sqrt(JumpHeight * 2 * -gravity);
        Debug.Log(velocity.y);
        //Debug.Log("We are in this func");

    }
}
