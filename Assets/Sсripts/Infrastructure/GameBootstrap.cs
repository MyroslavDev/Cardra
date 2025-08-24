using UnityEngine;

public class GameBootstrap : MonoBehaviour
{
    private GameStateMachine _stateMachine;
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        _stateMachine = new GameStateMachine(this);
        _stateMachine.ChangeState<EntryPointState>();
    }
}