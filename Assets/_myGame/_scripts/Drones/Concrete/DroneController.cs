using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneController : Singleton<DroneController>
{
    [SerializeField] DroneScriptable[] _droneScriptables;
    [field:SerializeField] public List<GameObject> DronePrefabs;
    Drone _currentDrones;
    DronesFollowTarget _dronesFollowTarget;
 
    void Start()
    {
        _dronesFollowTarget = GetComponent<DronesFollowTarget>();
        AddDrone(0);
        _dronesFollowTarget.SetFollowOffsets(DronePrefabs);
    }

    void LateUpdate()
    {
        _dronesFollowTarget.DronesFollowPlayer(DronePrefabs);
    }
    void AddDrone(int addedDrone)
    {
        _currentDrones = DroneCreator.CreateDrone(_droneScriptables[addedDrone]);
        DronePrefabs[addedDrone].SetActive(true);
    }
    
    //void DeActiveDrone(int removedDrone) { }
 
   
   
 
    

}
