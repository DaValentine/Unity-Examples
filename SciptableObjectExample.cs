using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum TypeOf
{
    rifle,
    pistol,
    launcher,
    sword,
    knife

}

[CreateAssetMenu]
public class SciptableObjectExample : ScriptableObject
{
    public string itemID;
    public string itemName;
    public string itemcost;
    public bool isRare;

}
