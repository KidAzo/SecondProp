using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Drone 
{
    public float attackDelay;
    public float attackDamage;
    public float damageRange;
    public float range;
    public DroneAnimController droneAnimController;

    public abstract void DoDamage();
    public abstract void FollowPlayer();
}


