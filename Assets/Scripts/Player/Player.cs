using UnityEngine;
using System.Collections;
using Huffy.Utilities;

[RequireComponent(typeof(Motor))]
public class Player : MonoBehaviour
{
    [HideInInspector] public Motor motor;
    private StateMachine<Player> stateMachine;
    void OnEnable()
    {
        motor = this.GetComponent<Motor>();
        stateMachine = new StateMachine<Player>(new PlayerIdleState(this));
    }

	void Update ()
    {
        if(stateMachine != null)
            stateMachine.Update();
	}
}
