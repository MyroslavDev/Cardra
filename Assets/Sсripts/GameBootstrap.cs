
using UnityEngine;

public class GameBootstrap : MonoBehaviour
{
    private GameStateMachine _stateMachine;

    private void Start()
    {
        _stateMachine = new GameStateMachine();
        _stateMachine.ChangeState<EntryPointState>();
    }
}