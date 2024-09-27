using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Groot : SuperHero
{
    //SpecialAbility
    public  void SpecialAbility()
    {
        Debug.Log($"{Name} used I !!! am !!! Groot !!!!!!");
    }
    public void GrootMove()
    {
        Debug.Log($"{Name} used I am Groot");

    }
    public void GrootAttack()
    {
       Debug.Log($"{Name} used I AM GROOT");

    }
    //Move, Attack override
    public override void Move()
    {
        GrootMove();
    }
    public override void Attack()
    {
        GrootAttack();
    }
    public override void Start()
    {
        base.Start();
        Name = "Groot";
        Move();
        Attack();
        SpecialAbility();
    }
}
