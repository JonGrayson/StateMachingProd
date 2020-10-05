using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnlargeState : IPlayerState
{
    public void Enter(Player player)
    {
        player.m_CurrentState = new EnlargeState();
        player.transform.localScale *= 2f;
        Debug.Log("Enlarge: Player is enlarged");
    }

    public void Execute(Player player)
    {
        if(Input.GetKeyUp("e"))
        {
            player.transform.localScale *= .5f;
            StandingState stand = new StandingState();
            stand.Enter(player);
        }
    }
}
