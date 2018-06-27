using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Scriptable Object class for Weapon data.

//Contains single public WeaponEntry and can be used to create preset weapons.

//Player should directly use WeaponEntry class when creating preset weapons and information should be stored as
//a WeaponEntry xml when serializing.

[CreateAssetMenu(fileName = "New Weapon", menuName = "Custom/Weapon")]
public class WeaponPreset : ScriptableObject
{
    public WeaponCustom data;
}
