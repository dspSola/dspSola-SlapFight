using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Entity 
{
    // identité
    public string _name;
    public List<string> _item;

    // faculté
    public float _force;
    public float _speed;
    public float _life;
    public float _damage;
    public float _precision;
    public float _muscularMass;
    public float _resistance;
    public float _scoreAttackQTE;
    public float _scoreDefenceQTE;
    public float _scoreQTE;

    // état
    public bool _isAttack;
    public bool _isDefence;
    public bool _ko;
    public bool _isLoosing;
    public bool _isWinning;

    public abstract void LessLife();
    public abstract void ForceQTE();
    public abstract void DefenceQTE();
    public abstract void ScoreQTE();
}
