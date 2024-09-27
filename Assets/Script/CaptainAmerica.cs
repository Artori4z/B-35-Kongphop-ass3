using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaptainAmerica : SuperHero
{
    public void LeapAndJump()
    {
        Debug.Log($"--------{Name} is Leap and Jump!!!");

    }
    public void ThrowShield()
    {
        Debug.Log($"========={Name} is Trowing Shield!!!");

    }
    //override
    public override void Move()
    {
       LeapAndJump();
    }
    public override void Attack()
    {
        ThrowShield();
    }
    public override void Start()
    {
        base.Start();
        Name = "Steve";
        Move();
        Attack();
    }

}