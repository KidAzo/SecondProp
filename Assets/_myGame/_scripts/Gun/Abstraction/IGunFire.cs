using UnityEngine;

public interface IGunFire
{
    void Fire(Transform myGunTransform, float attackDelay, float attackDamage,float range, GunAnim gunAnim);
}
