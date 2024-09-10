using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController1 : MonoBehaviour
{
    public IPlayerState currentState;

    private void Awake()
    {
        currentState = new StandingState();
    }

    void Update()
    {
        currentState.Execute(this);
    }
}
