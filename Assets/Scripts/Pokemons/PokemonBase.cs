using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Pokemon", menuName = "Pokemon/Create new pokemon")]
public class PokemonBase : ScriptableObject
{
    [SerializeField] string name;

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

    public MoveBase Base
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



