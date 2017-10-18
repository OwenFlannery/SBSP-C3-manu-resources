﻿using UnityEngine;

public class ManuModel{

    /// <summary>
    /// items that can be manufactured 
    /// </summary>
    private string manufactureText = "Manufacture";
    private string rockets = "Bang Bang Pew Pew ";
    private string fuel = "Stuff for flying";
    private string ammo = "Bang Bang ";

    /// <summary>
    /// setters for manu facture items 
    /// </summary>
    /// <returns></returns>
    public string GetManufactureText()
    {
        return manufactureText;
    }
    public string GetRockets()
    {
        return rockets;
    }
    public string GetFuel()
    {
        return fuel;

    }
    public string GetAmmo()
    {
        return ammo;
    }
}