using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private enum PlayerState
    {
        Idle,
        Walking,
        Aerial,
        Attacking
    }

    private PlayerState currentState;

    private void Start()
    {
        currentState = PlayerState.Idle;
    }

    private void Update()
    {
        switch (currentState)
        {
            case PlayerState.Idle:
                IdleState();
                break;
            case PlayerState.Walking:
                WalkingState();
                break;
            case PlayerState.Aerial:
                AerialState();
                break;
            case PlayerState.Attacking:
                AttackingState();
                break;
        }
    }

    private void IdleState()
    {
        CheckForInput();
    }

    private void WalkingState()
    {
        // Placeholder for walking behavior
        Debug.Log("Walking");

        // Example transition back to idle
        if (Input.GetKeyUp(KeyCode.W))
        {
            currentState = PlayerState.Idle;
        }
    }

    private void AerialState()
    {
        // Placeholder for aerial behavior
        Debug.Log("Aerial");

        // Example transition back to idle
        if (Input.GetKeyDown(KeyCode.Space))
        {
            currentState = PlayerState.Idle;
        }
    }

    private void AttackingState()
    {
        // Placeholder for attacking behavior
        Debug.Log("Attacking");

        // Example transition back to idle
        if (Input.GetKeyDown(KeyCode.A))
        {
            currentState = PlayerState.Idle;
        }
    }

    private void CheckForInput()
    {
        // Placeholder for input checks
        if (Input.GetKeyDown(KeyCode.W))
        {
            currentState = PlayerState.Walking;
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            currentState = PlayerState.Aerial;
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            currentState = PlayerState.Attacking;
        }
    }
}
