using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
  

  
    [SerializeField] float _movementSpeed;

    CharacterController _characterController;
    PlayerAnimController _playerAnimController;
    

    void Awake() 
    {
        _characterController = GetComponent<CharacterController>();
        _playerAnimController = GetComponent<PlayerAnimController>();
    }


 

    public void GeneralMovement(float deltaTime)
    {
         LocomotionSet(deltaTime);
         Movement(deltaTime);
    }

    void LocomotionSet(float deltaTime)
    {
        if (UI_Controller.Instance.Joystick.Horizontal != 0 ||
            UI_Controller.Instance.Joystick.Vertical != 0 )
        {
            this.transform.localRotation =  Quaternion.LookRotation(_characterController.velocity);
            _playerAnimController.SetSpeedHash(1f,deltaTime);
        }
        else
        {
            _playerAnimController.SetSpeedHash(0f,deltaTime);
        }


    }

    void Movement(float deltaTime)
    {
        Vector3 movement = new Vector3();

        movement = new Vector3(UI_Controller.Instance.Joystick.Horizontal * _movementSpeed,
            0,
            UI_Controller.Instance.Joystick.Vertical * _movementSpeed);
        

        _characterController.Move(movement * deltaTime);

    } 

}


