using UnityEngine;
using System.Collections;
using System;
using Huffy.Utilities;

public class PlayerIdleState : State<Player>
{
    public PlayerIdleState(Player _owner) : base(_owner)
    {
    }

    public override void Enter()
    {
        UIDebug.Log("Enter: " + this);
    }

    public override void Exit()
    {
        UIDebug.Log("Exit: " + this);
    }

    public override void Update()
    {
        if(Input.GetKeyDown("2"))
        {
            sm.ChangeState(new PlayerOnFootState(owner));
        }
    }
}
