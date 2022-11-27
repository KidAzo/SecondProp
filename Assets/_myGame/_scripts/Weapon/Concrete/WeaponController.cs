using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{    
    [SerializeField] WeaponScriptableObject[] gunScriptableObject;
    Weapon _selectedWeapon;     
    int _selectedGunIndex;

    void Start()
    {
        SelectGun();
    }
  
    void Update()
    {
       GunControll();
    }

    void SelectGun()
    {
        _selectedWeapon = WeaponCreator.CreateWeapon(gunScriptableObject[_selectedGunIndex]);
    }

    void GunControll()
    {     
      if(EnemyDedector.Instance.EnemyList.Count > 0)
      {
            _selectedWeapon.DoDamage();
            return;
      }
      
      _selectedWeapon.gunAnim.FireAnim(false);     
    }




}
