
public abstract class Weapon
{
   public float attackDelay;
   public float attackDamage;
   public float maxTargetCount;
   public float range;
   public WeaponAnimationController gunAnim;
        
    public abstract void DoDamage();
}