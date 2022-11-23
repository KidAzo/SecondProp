using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectricalDrone : Drone 
{
    public ElectricalDrone(DroneScriptable droneScriptable)
    {
        attackDelay = droneScriptable.attackDelay;
        attackDamage = droneScriptable.attackDamage;
        damageRange = droneScriptable.damageRange;
        range = droneScriptable.range; 
        droneAnimController = droneScriptable.droneAnimController;
    }

    public override void DoDamage()
    {
       
    }

    public override void FollowPlayer()
    {

    }
}
