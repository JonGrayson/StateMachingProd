using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckingState : IPlayerState
{
    public void Enter(Player player)
    {
        player.m_CurrentState = new DuckingState();
        player.transform.localScale *= .5f;
        Debug.Log("Ducking: Player is ducking");
    }

    public void Execute(Player player)
    {
        if(Input.GetKeyUp("s"))
        {
            player.transform.localScale *= 2f;
            StandingState stand = new StandingState();
            stand.Enter(player);
        }
    }
}
