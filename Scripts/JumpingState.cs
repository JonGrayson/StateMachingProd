using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpingState : IPlayerState
{
    public float jumpTime;

    public void Enter(Player player)
    {
        player.m_CurrentState = new JumpingState();
        player.GetComponent<Rigidbody>().velocity = new Vector3(0, 10f, 0);
        Debug.Log("Jumping: Player is now jumping");
    }

    public void Execute(Player player)
    {
        if(Input.GetKeyDown("s"))
        {
            DivingState dive = new DivingState();
            dive.Enter(player);
        }

        jumpTime += Time.time;

        if(Physics.Raycast(player.transform.position, Vector3.down, .5f))
        {
            StandingState stand = new StandingState();
            stand.Enter(player);
        }
    }
}
