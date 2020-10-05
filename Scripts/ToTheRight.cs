using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToTheRight : IPlayerState
{
    public void Enter(Player player)
    {
        player.m_CurrentState = new ToTheLeft();
        player.GetComponent<Rigidbody>().velocity = new Vector3(-2f, 0, 0);
        Debug.Log("ToTheRight: To the right, the right, the right, the right, the right");
    }

    public void Execute(Player player)
    {
        StandingState stand = new StandingState();
        stand.Enter(player);
    }
}
