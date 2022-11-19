using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunAnim : MonoBehaviour
{
    [SerializeField] Animator _animator;



    public void FireAnim(bool value)
    {
        _animator.SetBool("Fire", value);
    }
}
