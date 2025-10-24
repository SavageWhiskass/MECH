using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    //Define Vairable
    public float MoveSpeed;
    public Rigidbody Rigidbody;
    private Vector2 moveDirection;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //processInputs
        ProcessInputs();
    }

    //called at a set intival

     void FixedUpdate()
     {
        //physics Calculater
        Move();
     }

    void ProcessInputs()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector2(moveX, moveY).normalized;
    }
    ///<summary>
    ///Callback for processing animation movements for modifying root motion
    ///<summary>

    private void OnAnimatorMove()
    {
        
    }

    void Move()
    {
        Rigidbody.velocity = new Vector2(moveDirection.x * MoveSpeed, moveDirection.y * MoveSpeed);
    }
}


