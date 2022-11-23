using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "CreateWeapon", menuName = "ScriptableObjects/Drones", order = 2)]
public class DroneScriptable : ScriptableObject
{
    public float attackDelay;
    public float attackDamage;
    public float damageRange;
    public float maxTargetCount;
    public float range;
    public DroneAnimController droneAnimController;
    public DroneType droneType;
}

public enum DroneType
{
    ElectricalDrone
}
