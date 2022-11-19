using UnityEngine;

public interface IGunTurn
 {
     void GurnSearchMode(Transform myGunTransform,Vector3 rotation,float speed,float deltaTime);
     void TurnEnemy(Transform myGunTransform , Transform currentTargetPos);
 }
