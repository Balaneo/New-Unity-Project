using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

//Manages save data and stores the information at runtime.
public static class SaveManager {

    //SAVE DATA
    //Investigators Save
    private static InvestigatorsSave investigatorsSave;

    //Skills Save
    private static SkillsSave skillsSave;

    //Weapons Save
    private static WeaponsSave weaponsSave;

    //Options Save
    private static OptionsSave optionsSave;


    //EVENT DELEGATES
    //On Save delegate and event
    public delegate void SaveDelegate();
    public static event SaveDelegate OnSave;

    //On Load delegate and event
    public delegate void LoadDelegate();
    public static event LoadDelegate OnLoad;

    //Initialise Save Data
    public static void InitialiseSaveData()
    {
        string json_weaponSave = JsonUtility.ToJson(weaponsSave); //Parse save object class into string
        FileStream stream = new FileStream(Application.persistentDataPath + "/WeaponSave.json", FileMode.Create); //Create a file stream and prep file for create
        StreamWriter writer = new StreamWriter(stream); //Create a writer and link to the stream
        writer.Write(json_weaponSave); //Write json data into stream with writer
        writer.Close();
        stream.Close();
    }

    public static void DeleteSaveData()
    {
        if (File.Exists(Application.persistentDataPath + "/WeaponSave.json"))
        {
            File.Delete(Application.persistentDataPath + "/WeaponSave.json");
        }

        InitialiseSaveData();
    }

    //Get the weapon save variable
    public static WeaponsSave GetSaveData()
    {
        return weaponsSave;
    }

    //Write to JSON from save object variable
    public static void Save()
    {
        string json_weaponSave = JsonUtility.ToJson(weaponsSave); 
        FileStream stream = new FileStream(Application.persistentDataPath + "/WeaponSave.json", FileMode.Create); 
        StreamWriter writer = new StreamWriter(stream);
        writer.Write(json_weaponSave);
        writer.Close();
        stream.Close();

        //Fire OnSave delegate
        if (OnSave != null)
        {
            OnSave();
        }
    }

    //Read from JSON into save object variable
    public static void Load()
    {
        weaponsSave = JsonUtility.FromJson<WeaponsSave>(File.ReadAllText(Application.persistentDataPath + "/WeaponSave.json"));

        //Fire OnLoad delegate
        if (OnLoad != null)
        {
            OnLoad();
        }
    }
}
