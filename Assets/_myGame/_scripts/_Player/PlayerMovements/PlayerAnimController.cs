using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerAnimController : MonoBehaviour
{

     Animator _animator;
     readonly int LocomotionHash = Animator.StringToHash("Locomotion");
     readonly int SpeedHash = Animator.StringToHash("Speed");


    
    void Awake()
    {
       _animator = GetComponentInChildren<Animator>();
       _animator.CrossFadeInFixedTime(LocomotionHash,0.1f);
    }

    
    public void SetSpeedHash(float currentHash,float deltaTime)
    {
       _animator.SetFloat(SpeedHash,currentHash,.1f,deltaTime);
    }
  
}
