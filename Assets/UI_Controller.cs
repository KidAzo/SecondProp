using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Controller : Singleton<UI_Controller>
{
   FloatingJoystick _joystick;

   public FloatingJoystick Joystick => _joystick;
   
   protected override void Awake()
   {
       base.Awake();
      _joystick = GetComponentInChildren<FloatingJoystick>();  
   } 
    


}
