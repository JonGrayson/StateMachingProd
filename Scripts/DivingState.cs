using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DivingState : IPlayerState
{
    public void Enter(Player player)
    {
        player.m_CurrentState = new DivingState();
        player.GetComponent<Rigidbody>().velocity = new Vector3(0, -20f, 0);
        Debug.Log("Diving: Player is now diving");
    }

    public void Execute(Player player)
    {
        if(Physics.Raycast(player.transform.position, Vector3.down, .5f))
        {
            StandingState stand = new StandingState();
            stand.Enter(player);
        }
    }
}
