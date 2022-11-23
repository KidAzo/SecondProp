using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : Singleton<PlayerController> 
{

     PlayerMode _playerMode;
     PlayerMovement _playerMovement;


    protected override void Awake()
    {
        base.Awake();
        _playerMode = PlayerMode.Locomotion;
        _playerMovement = GetComponent<PlayerMovement>();
       
    }
    void Update()
    {
        SwitchPlayerMode(_playerMode);
    }



    void SwitchPlayerMode(PlayerMode playerMode)
    {

        switch (playerMode)
        {
            case PlayerMode.Locomotion:
                _playerMovement.GeneralMovement(Time.deltaTime);
                break;


            default:
                break;
        }



    }




}

public enum PlayerMode
{
    Locomotion,
}