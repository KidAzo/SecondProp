using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "CreateWeapon", menuName = "ScriptableObjects/Weapons", order = 1)]
public class WeaponScriptableObject : ScriptableObject
{
    
   public float attackDelay;
   public float attackDamage;
   public float maxTargetCount;
   public float range;
   public WeaponAnimationController weaponAnim;
   public GunType GunType;

}

public enum GunType
{
    ElectricalWeapon
}