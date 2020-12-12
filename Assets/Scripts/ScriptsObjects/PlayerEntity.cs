using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEntity : Entity
{
    public float _zoneQTE;
    public float _hiQTE;
    public float _midQTE;
    public float _lowQTE;

    public override void LessLife()
    {
        _life -= _damage;
    }

    public override void ForceQTE()
    {
        if (_isAttack)
        {
            _damage -= _scoreAttackQTE;
        }
    }

    public override void DefenceQTE()
    {
        if (_isDefence)
        {
            _resistance -= _scoreDefenceQTE;
        }
    }

    public override void ScoreQTE()
    {
        throw new System.NotImplementedException();
        _scoreQTE -= _force + _speed + _precision + _muscularMass;
    }
}
