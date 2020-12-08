using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity 
{
    // identité
    string name;
    List<string> item;

    // faculté
    float force;
    float speed;
    float life;
    float damage;
    float precision;
    float muscularMass;

    //
    bool ko;
    bool loose;
    bool win;
}
