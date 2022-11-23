using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDedector : Singleton<EnemyDedector>
{
    public List<Enemy> _enemyList = new List<Enemy>();

    public List<Health> _healthList = new List<Health>();
      
    public List<Enemy> EnemyList { get => _enemyList; set => _enemyList = value; }
    public List<Health> HealthList { get => _healthList; set => _healthList = value; }


    public int enemyCount;
     
    void OnTriggerEnter(Collider other) 
    {
        if(!other.TryGetComponent<Enemy>(out Enemy enemy)) return;

        Health health = other.GetComponent<Health>();

        _enemyList.Add(enemy);
        _healthList.Add(health);
    }
    
    void OnTriggerExit(Collider other) 
    {
        if(!other.TryGetComponent<Enemy>(out Enemy enemy)) return;

        Health health = other.GetComponent<Health>();


        _enemyList.Remove(enemy);
        _healthList.Remove(health);
    }

}
