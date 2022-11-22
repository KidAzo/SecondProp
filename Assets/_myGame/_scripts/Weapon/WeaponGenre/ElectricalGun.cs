using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectricalGun : Weapon , IWeaponTargetEnemy
{
    RaycastHit hit;
    float nextTimeForFire = 0f;

    public ElectricalGun(WeaponScriptableObject gunScriptableObject)
    {
        attackDelay = gunScriptableObject.attackDelay;
        attackDamage = gunScriptableObject.attackDamage;
        range = gunScriptableObject.range;
        gunAnim = gunScriptableObject.weaponAnim;
    }

    public override void DoDamage()
    {
        TurnEnemy(EnemyDedector.Instance.CurrentTarget.transform);
        if (Physics.Raycast(weaponRayTransform.position, weaponRayTransform.forward, out hit, range))
        {
            if (!hit.transform.gameObject.TryGetComponent<Health>(out Health health)) return;


            if (Time.time >= nextTimeForFire)
            {
                nextTimeForFire = Time.time + attackDelay;
                gunAnim.FireAnim(true);
                health.TakeDamage(attackDamage);
            }



        }
    }

    public void TurnEnemy(Transform currentTargetPos)
    {
        Vector3 directionOnFace = currentTargetPos.position - weaponRayTransform.position;
        weaponRayTransform.rotation = Quaternion.LookRotation(directionOnFace);
    }
}
