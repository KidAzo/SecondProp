using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon
{
   public Transform weaponRayTransform;
   public float attackDelay;
   public float attackDamage;
   public float maxTargetCount;
   public float range;
   public WeaponAnimationController gunAnim;
       
   
    public abstract void DoDamage();
}