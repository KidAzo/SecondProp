using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[RequireComponent(typeof(Animator))]
public class WeaponAnimationController : MonoBehaviour
{
    [field: SerializeField] public Animator WeaponAnimator { get; private set; }

    public void FireAnim(bool value)
    {
        WeaponAnimator.SetBool("Fire", value);
    }
}
