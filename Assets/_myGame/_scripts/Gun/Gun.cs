using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
     
     [SerializeField] EnemyDedector _enemyDedector;
     IGunTurn _gunTurn;
    
    void OnEnable() 
    {
        _gunTurn = new GunTurn();
    }
    
    void Update()
    {
       GunControll();
    }

    void GunControll()
    {
      
      if(_enemyDedector.EnemyList.Count != 0)
      {
          _enemyDedector.SelectTarget();        
          _gunTurn.TurnEnemy(this.transform , _enemyDedector.CurrentTarget.transform); 
         return; 
      }
      
       _gunTurn.GurnSearchMode(this.transform);
    }

     

}
