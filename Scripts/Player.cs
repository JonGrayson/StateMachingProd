using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public IPlayerState m_CurrentState;
    public Rigidbody rb;

    void Awake()
    {
        rb = this.GetComponent<Rigidbody>();
        m_CurrentState = new StandingState();
        m_CurrentState.Enter(this);
    }

    void Update()
    {
        m_CurrentState.Execute(this);
    }
}
