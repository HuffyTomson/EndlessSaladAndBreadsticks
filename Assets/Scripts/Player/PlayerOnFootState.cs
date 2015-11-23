using UnityEngine;
using System.Collections;
using System;
using Huffy.Utilities;

public class PlayerOnFootState : State<Player>
{
    public PlayerOnFootState(Player _owner) : base(_owner)
    {
    }

    public override void Enter()
    {
        UIDebug.Log("Enter: " + this);
        // set motor to on foot
    }

    public override void Exit()
    {
        UIDebug.Log("Exit: " + this);
    }

    public override void Update()
    {
        if(Input.GetKeyDown("1"))
        {
            sm.ChangeState(new PlayerIdleState(owner));
        }

        Vector3 inputVec = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"),0);
        owner.motor.InputDirection(inputVec);
    }
}
