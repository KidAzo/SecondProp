using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[RequireComponent(typeof(Animator))]
public class DroneAnimController : MonoBehaviour
{
    [field: SerializeField] public Animator DroneAnimator { get; private set; }

    public void FireAnim(bool value)
    {
        DroneAnimator.SetBool("DroneFire", value);
    }
}
