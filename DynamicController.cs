using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicController : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 direction;
    public float Dynamic_speed=10;
    public int Line=1; //0-left, 1-middle, 2-right
    public float Line_Distance=4; //distance between lines

    // Start is called before the first frame update
    void Start()
    {
        controller=GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        direction.z = Dynamic_speed;

        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            Line++;
            if(Line ==3){
                Line=2;
                 Debug.Log("2 line");
            }
        }
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Line--;
            if(Line == -1){
                Line=0;
                Debug.Log("0 line");
            }
        }

        Vector3 Position_Target=transform.position.z * transform.forward + transform.position.y * transform.up;

        if(Line == 0)
        {
            Position_Target += Vector3.left * Line_Distance;
            
        }
        else if( Line == 2)
        {
            Position_Target += Vector3.right * Line_Distance;
        }
        //transform.position = Position_Target;
    }

     private void FixedUpdate()
    {
        controller.Move(direction * Time.deltaTime);
    }
}
