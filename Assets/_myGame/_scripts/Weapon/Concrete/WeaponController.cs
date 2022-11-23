using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{    
     EnemyDedector _enemyDedector;  
     [SerializeField] Transform[] _gunRayPos;
     [SerializeField] WeaponScriptableObject[] gunScriptableObject;
     Weapon _selectedWeapon;     
     int _selectedGunIndex;

    void Start()
    {
        _enemyDedector = EnemyDedector.Instance;
        SelectGun();
    }
  
    void Update()
    {
       GunControll();
    }

    Weapon CreateWeapon()
    {
        WeaponScriptableObject currentScriptableObject = gunScriptableObject[_selectedGunIndex];
        switch (currentScriptableObject.GunType)
        {
            case GunType.ElectricalWeapon:
                return new ElectricalGun(currentScriptableObject);
            default:
                return null;
        }
    }

    void SelectGun()
    {
        _selectedWeapon = CreateWeapon();
    }

    void GunControll()
    {     
      if(_enemyDedector.EnemyList.Count > 0)
      {
            _selectedWeapon.DoDamage();
            return;
      }
      
      _selectedWeapon.gunAnim.FireAnim(false);     
    }

   

     

}
