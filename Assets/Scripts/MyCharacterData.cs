using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCharacterData
{
    public string Name { get; private set; }
    public int Level { get; private set; }
    public float Atk { get; private set; }
    public float Def { get; private set; }
    public float Hp { get; private set; }
    public float Crt { get; private set; }  
    public float Gold { get; private set; }

    
    public MyCharacterData(string name, int level, float atk, float def, float hp, float crt, float gold)
    {
        Name = name;
        Level = level;
        Atk = atk;
        Def = def;
        Hp = hp;
        Crt = crt;
        Gold = gold;

        
    }

    public override string ToString()
    {
        return $"{Name}, {Level}, {Atk}, {Def}, {Hp}, {Crt}, {Gold}";
    }

    
}
