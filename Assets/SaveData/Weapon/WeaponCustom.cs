using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Serializable data for Weapons.
//Can be used for Custom weapon saves to be filled out by the player.

[System.Serializable]
public class WeaponCustom
{
    public string label = "New Label";
    public string skill = "Brawl";
    public string damage = "1D4 + DB";
    public string range = "5 yards";
    public int usesPerRound = 1;
    public int bulletsInGun = 1;
    public int malfunction = 100;
    public int quantity = 1;
}
