using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Button entry for weapon display. 

public class WeaponButton : Button
{
    private Text textTarget;

    public void SetWeaponInfo(WeaponCustom weapon)
    {
        textTarget = this.GetComponentInChildren<Text>();

        if (textTarget)
        {
            textTarget.text = weapon.label;
        }
    }
}
