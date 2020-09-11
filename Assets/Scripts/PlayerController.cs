using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    PlayerInput controls;

    void Awake(){
        controls = new PlayerInput();
        controls.Enable();

        controls.Player.Button.performed += Fire;
        controls.Player.Button.canceled += Stop;
        controls.Player.Movement.performed += Move;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Fire(InputAction.CallbackContext context){
        Debug.Log("test");
    }

    public void Move(InputAction.CallbackContext context){
        Debug.Log(context.ReadValue<Vector2>());
    }

    public void Stop(InputAction.CallbackContext context){
        Debug.Log("canceled");
    }
}
