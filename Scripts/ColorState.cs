using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorState : IPlayerState
{
    public void Enter(Player player)
    {
        player.m_CurrentState = new ColorState();
        player.GetComponent<Renderer>().material.color = Color.cyan;
        Debug.Log("Color: Player is having color changed");
    }

    public void Execute(Player player)
    {
        if (Input.GetKeyUp("c"))
        {
            player.GetComponent<Renderer>().material.color = Color.red;
            StandingState stand = new StandingState();
            stand.Enter(player);
        }
    }
}
