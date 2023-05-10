﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pokemon : PokemonBase
{
    PokemonBase _base;
    int level;

    public int HP {get; set;}

    public List<Move> Moves {get; set;}

    public Pokemon(PokemonBase pBase, int pLevel)
    {
        _base = pBase;
        level = pLevel;
        HP = _base.MaxHp;

        //Generate Moves
        Moves = new List<Move>();
        foreach(var move in _base.LearnableMoves)
        {
            if(move.Level <= level)
            {
                Moves.Add(new Move(move.MoveBase));
            }

            if(Moves.Count >= 4){
                break;
            }
        }
    }

    public int Attack{
        //this is the actual formula used in Pokemon
        get {return Mathf.FloorToInt((_base.Attack * level) / 100f) + 5;}
    }
    public int Defense
    {
        get { return Mathf.FloorToInt((_base.Defense * level) / 100f) + 5; }
    }

    public int SpAttack
    {
        get { return Mathf.FloorToInt((_base.SpAttack * level) / 100f) + 5; }
    }

    public int SpDefense
    {
        get { return Mathf.FloorToInt((_base.SpDefense * level) / 100f) + 5; }
    }

    public int Speed
    {
        get { return Mathf.FloorToInt((_base.Speed * level) / 100f) + 5; }
    }

    // MaxHp adds 10 at the end instead of 5
    public int MaxHp
    {
        get { return Mathf.FloorToInt((_base.MaxHp * level) / 100f) + 10; }
    }
}
