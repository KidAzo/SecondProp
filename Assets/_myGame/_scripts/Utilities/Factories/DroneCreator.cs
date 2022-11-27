using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneCreator 
{
    public static Drone CreateDrone(DroneScriptable droneScriptable)
    {
        Drone drone = null;
        switch (droneScriptable.droneType)
        {            
            case DroneType.ElectricalDrone:
                drone = new ElectricalDrone(droneScriptable);
                break;
            default:
                break;
        }

        return drone;
    } 
    


}
