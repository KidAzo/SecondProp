using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class GunTurn : IGunTurn
{
   public void GurnSearchMode(Transform myGunTransform,Vector3 rotation,float speed,float deltaTime)
   {
       myGunTransform.Rotate(rotation * speed * deltaTime);
   }
   public void TurnEnemy(Transform myGunTransform , Transform currentTargetPos)
   {
       Vector3 directionOnFace = currentTargetPos.position - myGunTransform.position;
       myGunTransform.rotation =  Quaternion.LookRotation(directionOnFace); 
   }
}



