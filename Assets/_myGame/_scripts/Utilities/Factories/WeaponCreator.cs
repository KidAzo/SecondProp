using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponCreator 
{
    public static Weapon CreateWeapon(WeaponScriptableObject weaponScriptableObject)
    {
        Weapon currentweapon = null;
        switch (weaponScriptableObject.GunType)
        {            
            case GunType.ElectricalWeapon:
                currentweapon = new ElectricalWeapon(weaponScriptableObject);
                break;
            default:
                break;
        }

        return currentweapon;
    } 
    


}
