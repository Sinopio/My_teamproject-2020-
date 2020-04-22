using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Monster
{
    public string MobName;
    public GameObject MobObject;
    public int weight;

    public Monster(Monster monster)
    {
        this.MobName = monster.MobName;
        this.MobObject = monster.MobObject;
        this.weight = monster.weight;
            
    }
}

