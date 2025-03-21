using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterData 
{
    public string Name;
    public int Level;
    public float Atk;
    public float Def;
    public float Hp;
    public float Crt;
    public float Gold;
   public CharacterData(string name, int level, float atk, float def, float hp, float crt, float gold)
    {
        Name = name;
        Level = level;
        Atk = atk;
        Def = def;
        Hp = hp;
        Crt = crt;
        Gold = gold;
    }
}
