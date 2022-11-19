using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunFire : IGunFire
{

    RaycastHit hit;
    float nextTimeForFire=0f;
    public void Fire(Transform mygunTransform , float attackDelay, float attackDamage, float range, GunAnim gunAnim)
    {
        if (Physics.Raycast(mygunTransform.position, mygunTransform.forward, out hit, range))
        {
            if (!hit.transform.gameObject.TryGetComponent<Health>(out Health health)) return;
          

            if(Time.time >= nextTimeForFire)
            {
                nextTimeForFire = Time.time + attackDelay;
                gunAnim.FireAnim(true);
                KillEnemy(health, attackDamage);
            }
             
           
            
        }
    }

    void KillEnemy(Health health,float attackDamage)
    {
        health.TakeDamage(attackDamage);
    }

}
