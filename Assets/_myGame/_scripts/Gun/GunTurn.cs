using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class GunTurn : IGunTurn
{
   
   public void GurnSearchMode(Transform transform)
   {
       transform.DORotate(new Vector3(0, 360, 0), 1f,RotateMode.LocalAxisAdd).SetEase(Ease.Linear);
   }

   public void TurnEnemy(Transform myGunTransform , Transform currentTargetPos)
   {
       Vector3 directionOnFace = currentTargetPos.position - myGunTransform.position;
       myGunTransform.rotation =  Quaternion.LookRotation(directionOnFace); 
   }
}


public interface IGunTurn
{
    void GurnSearchMode(Transform transform);
    void TurnEnemy(Transform myGunTransform , Transform currentTargetPos);
}
