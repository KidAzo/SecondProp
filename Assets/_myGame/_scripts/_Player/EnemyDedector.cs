using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDedector : Singleton<EnemyDedector>
{
     public List<Enemy> _enemyList = new List<Enemy>();
    
    
     public List<Enemy> EnemyList { get => _enemyList; set => _enemyList = value; }
     
   
     public Enemy CurrentTarget { get; private set;}

     

  

    
    void OnTriggerEnter(Collider other) 
    {
        if(!other.TryGetComponent<Enemy>(out Enemy enemy)) return;


        _enemyList.Add(enemy);
    }

    void OnTriggerExit(Collider other) 
    {
        if(!other.TryGetComponent<Enemy>(out Enemy enemy)) return;


        _enemyList.Remove(enemy);
    }


    public  void SelectTarget()
    {  
       CurrentTarget = _enemyList[0];
    }
}
