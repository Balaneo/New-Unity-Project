using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class ProfileList : MonoBehaviour
{
    public GameObject buttonPrefab;

    private void Start()
    {
        string[] profiles = GetProfiles();

        if(profiles != null)
        {
            foreach (string file in profiles)
            {
                GameObject newButton = Instantiate(buttonPrefab) as GameObject;
                newButton.transform.SetParent(transform, false);
                newButton.GetComponent<ProfileButton>().SetProfileInfo("We Found An Investigator!");
            }
        }
        else
        {
            GameObject newButton = Instantiate(buttonPrefab) as GameObject;
            newButton.transform.SetParent(transform, false);
            newButton.GetComponent<ProfileButton>().SetProfileInfo("No Investigators.\nPlease Create One!");
            newButton.GetComponent<ProfileButton>().interactable = false;
        }
    }

    public string[] GetProfiles()
    {
        string profilePath = Application.persistentDataPath + "/Investigators";

        if(Directory.Exists(profilePath))
        {
            string[] files = Directory.GetFiles(profilePath);

            return files;
        }
        else
        {
            return null;
        }
    }
}
