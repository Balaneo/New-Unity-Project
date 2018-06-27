using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class WeaponsSave
{
    //Preset Weapons List
    public List<WeaponPreset> weaponPresetList = new List<WeaponPreset>();

    //Custom Weapons List
    public List<WeaponCustom> weaponCustomList = new List<WeaponCustom>();
}
