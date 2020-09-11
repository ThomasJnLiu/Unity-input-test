using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController2 : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;

    private Vector2 inputMovement;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate(){
        rb.velocity = new Vector2(inputMovement.x * speed, rb.velocity.y);
    }
    void OnMovement(InputValue value){
        // get info about input for movement
        inputMovement = value.Get<Vector2>();
        
    }

    void OnJump(InputValue value){
        rb.AddForce(new Vector2(0,500f));
        Debug.Log("jump");
    }
}
