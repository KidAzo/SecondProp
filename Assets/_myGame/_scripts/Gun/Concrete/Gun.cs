using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
     
     [SerializeField] EnemyDedector _enemyDedector;
    
     [Header("GunDefaultMode")]
     [SerializeField] Vector3 _gunDefaultRotation;
     [SerializeField] float _gunRotationSpeed;
    
     IGunTurn _gunTurn;
     IGunFire _gunFire;
     GunAnim _gunAnim;


    [Header("GunFireProperties")]
    [SerializeField] float _attackDelay;
    [SerializeField] float _attackDamage;
    [SerializeField] float _attackRange;
    [SerializeField] Transform _gunRayPos;

    void Awake()
    {
        _gunAnim = GetComponent<GunAnim>();
    }
    void OnEnable() 
    {
        _gunTurn = new GunTurn();
        _gunFire = new GunFire();
    }
    
    void Update()
    {
       GunControll(Time.deltaTime);
    }

    void GunControll(float deltaTime)
    {
      
      if(EnemyDedector.Instance.EnemyList.Count > 0)
      {
          _enemyDedector.SelectTarget();
          _gunTurn.TurnEnemy(this.transform , _enemyDedector.CurrentTarget.transform);
          _gunFire.Fire(_gunRayPos, _attackDelay, _attackDamage, _attackRange, _gunAnim);
            return;
      }

        _gunAnim.FireAnim(false);
        _gunTurn.GurnSearchMode(this.transform, _gunDefaultRotation, _gunRotationSpeed, deltaTime);


    }

     

}
