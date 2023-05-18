using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Pokemon", menuName = "Pokemon/Create new pokemon")]
public class PokemonBase : ScriptableObject
{
    [SerializeField] new string name;

    [TextArea]
    [SerializeField] string description;

    [SerializeField] Sprite frontSprite;
    [SerializeField] Sprite backSprite;

    [SerializeField] PokemonType type1;
    [SerializeField] PokemonType type2;

    //Base stats
    [SerializeField] int maxHp;
    [SerializeField] int attack;
    [SerializeField] int defense;
    [SerializeField] int spAttack;
    [SerializeField] int spDefense;
    [SerializeField] int speed;

    [SerializeField] List<LearnableMove> learnableMoves;

    // Properties below this line (C#'s answer to encapsulations e.g. getters and setters in Java)
    // Name property
    public string Name
    {
        get { return name; }
    }

    // Description property
    public string Description
    {
        get { return description; }
    }

    // FrontSprite property
    public Sprite FrontSprite
    {
        get { return frontSprite; }
    }

    // BackSprite property
    public Sprite BackSprite
    {
        get { return backSprite; }
    }

    // Type1 property
    public PokemonType Type1
    {
        get { return type1; }
    }

    // Type2 property
    public PokemonType Type2
    {
        get { return type2; }
    }

    // MaxHp property
    public int MaxHp
    {
        get { return maxHp; }
    }

    // Attack property
    public int Attack
    {
        get { return attack; }
    }

    // Defense property
    public int Defense
    {
        get { return defense; }
    }

    // SpAttack property
    public int SpAttack
    {
        get { return spAttack; }
    }

    // SpDefense property
    public int SpDefense
    {
        get { return spDefense; }
    }

    // Speed property
    public int Speed
    {
        get { return speed; }
    }

    public List<LearnableMove> LearnableMoves
    {
        get {return learnableMoves;}
    }
        

}

[System.Serializable]
public class LearnableMove
{
    [SerializeField] MoveBase moveBase;
    [SerializeField] int level;

    public MoveBase MoveBase
    {
        get { return moveBase; }
    }

    public int Level
    {
        get { return level; }
    }
}

public enum PokemonType
{
    None,
    Normal,
    Fire,
    Water,
    Electric,
    Grass,
    Ice,
    Fighting,
    Poison,
    Ground,
    Flying,
    Psychic,
    Bug,
    Rock,
    Ghost,
    Dragon
}

public enum Stat
{
    Attack,
    Defense,
    SpAttack,
    SpDefense,
    Speed
}

public class TypeChart 
{
    static float[][] chart =
    {
        //                   NOR   FIR  WAT   ELE  GRS  POI
        /*NOR*/ new float[] { 1f,  1f,   1f,  1f,  1f,  1f,  1f,  1f,  1f,  1f,  1f,  1f, 0.5f, 0f,  1f,  1f, 0.5f },
        /*FIR*/ new float[] { 1f, 0.5f, 0.5f, 1f,  2f,  2f,  1f,  1f,  1f,  1f,  1f,  2f, 0.5f, 1f, 0.5f, 1f,  2f },
        /*WAT*/ new float[] { 1f,  2f,  0.5f, 2f, 0.5f, 1f,  1f,  1f,  2f,  1f,  1f,  1f,  2f,  1f, 0.5f, 1f,  1f },
        /*ELE*/ new float[] { 1f,  1f,   2f, 0.5f,0.5f, 2f,  1f,  1f,  0f,  2f,  1f,  1f,  1f,  1f, 0.5f, 1f,  1f },
        /*GRS*/ new float[] { 1f, 0.5f,  2f,  2f, 0.5f, 1f,  1f, 0.5f, 2f, 0.5f, 1f, 0.5f, 2f,  1f, 0.5f, 1f, 0.5f },
        /*POI*/ new float[] { 1f, 0.5f, 0.5f, 1f,  2f, 0.5f, 1f,  1f,  2f,  2f,  1f,  1f,  1f,  1f,  2f,  1f, 0.5f },
        /*XXX*/ new float[] { 2f,  1f,   1f,  1f,  1f,  2f,  1f, 0.5f, 1f, 0.5f, 0.5f, 0.5f, 2f, 0f, 1f,  2f,  2f },      
        /*XXX*/ new float[] { 1f,  1f,   1f,  1f,  2f,  1f,  1f, 0.5f, 0.5f, 1f, 1f,  1f, 0.5f, 0.5f, 1f, 1f,  0f },  
        /*XXX*/ new float[] { 1f,  2f,   1f,  2f, 0.5f, 1f,  1f,  2f,  1f,  0f,  1f, 0.5f, 2f,  1f,  1f,  1f,  2f },
        /*XXX*/ new float[] { 1f,  1f,   1f, 0.5f, 2f,  1f,  2f,  1f,  1f,  1f,  1f,  2f, 0.5f, 1f,  1f,  1f, 0.5f },
        /*XXX*/ new float[] { 1f,  1f,   1f,  1f,  1f,  1f,  2f,  2f,  1f,  1f, 0.5f, 1f,  1f,  1f,  1f,  0f, 0.5f },
        /*XXX*/ new float[] { 1f, 0.5f,  1f,  1f,  2f, 1f, 0.5f, 0.5f, 1f, 0.5f, 2f,  1f,  1f, 0.5f, 1f,  2f, 0.5f },
        /*XXX*/ new float[] { 1f,  2f,   1f,  1f,  1f,  2f, 0.5f, 1f, 0.5f, 2f,  1f,  2f,  1f,  1f,  1f,  1f, 0.5f },
        /*XXX*/ new float[] { 0f,  1f,   1f,  1f,  1f,  1f,  1f,  1f,  1f,  1f,  2f,  1f,  1f,  2f, 1f, 0.5f, 0.5f },
        /*XXX*/ new float[] { 1f,  1f,   1f,  1f,  1f,  1f,  1f,  1f,  1f,  1f,  1f,  1f,  1f,  1f,  2f,  1f,  0.5f},
        /*XXX*/ new float[] { 1f,  1f,   1f,  1f,  1f,  1f, 0.5f, 1f,  1f,  1f,  2f,  1f,  1f,  2f, 1f, 0.5f, 0.5f },
        /*XXX*/ new float[] { 1f, 0.5f, 0.5f, 0.5f, 1f, 2f,  1f,  1f,  1f,  1f,  1f,  1f,  2f,  1f,  1f,  1f,  0.5f }
    };

    public static float GetEffectiveness(PokemonType attackType, PokemonType defenseType)
    {
        if (attackType == PokemonType.None || defenseType == PokemonType.None)
            return 1;
        
        int row = (int)attackType - 1;
        int col = (int)defenseType - 1;

        return chart[row][col];
    }
}


