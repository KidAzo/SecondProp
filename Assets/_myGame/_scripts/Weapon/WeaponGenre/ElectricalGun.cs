using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectricalGun : Weapon 
{
    float nextTimeForFire = 0f;

    public ElectricalGun(WeaponScriptableObject gunScriptableObject)
    {
        attackDelay = gunScriptableObject.attackDelay;
        attackDamage = gunScriptableObject.attackDamage;
        range = gunScriptableObject.range;
        gunAnim = gunScriptableObject.weaponAnim;
        maxTargetCount = gunScriptableObject.maxTargetCount;
    }

    public override void DoDamage()
    {
        {

            if (Time.time >= nextTimeForFire)
            {
                nextTimeForFire = Time.time + attackDelay;
                gunAnim.FireAnim(true);
                for (int i = 0; i < EnemyDedector.Instance.HealthList.Count; i++)
                {
                    if (i == maxTargetCount) return;
                    EnemyDedector.Instance.HealthList[i].TakeDamage(attackDamage);
                }
            }
        }
    }

}
