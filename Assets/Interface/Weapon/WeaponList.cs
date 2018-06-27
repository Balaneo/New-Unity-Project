using System.Collections.Generic;
using UnityEngine;

//Scroll box container component for displaying weapon information from Xml Save Manager.

public class WeaponList : MonoBehaviour
{
    public GameObject buttonPrefab;

	// Use this for initialization
	void Start ()
    {
        SaveManager.InitialiseSaveData();

        //Listen for Load event
        SaveManager.OnLoad += RefreshDisplay;
        RefreshDisplay();		
	}

    private void OnDestroy()
    {
        SaveManager.OnLoad -= RefreshDisplay;
    }

    public void RefreshDisplay()
    {
        //Remove any existing entries in list
        foreach (Transform child in transform)
        {
            Destroy(child.gameObject);
        }

        if(SaveManager.GetSaveData() != null)
        {
            //Create button and add to list
            foreach (WeaponPreset weaponPreset in SaveManager.GetSaveData().weaponPresetList)
            {
                WeaponCustom newWeapon = weaponPreset.data;

                GameObject newButton = Instantiate(buttonPrefab) as GameObject;
                newButton.transform.SetParent(transform, false);
                newButton.GetComponent<WeaponButton>().SetWeaponInfo(newWeapon);
            }
        }
    }    
}
