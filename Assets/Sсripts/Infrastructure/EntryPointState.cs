
using UnityEngine;

public class EntryPointState : IGameState
{
    private GameStateMachine _stateMachine;

    public EntryPointState(GameStateMachine stateMachine)
    {
        _stateMachine = stateMachine;
    }

    public void Enter()
    {
        Debug.Log("Entry Point: показываем меню или загрузочный экран...");
        _stateMachine.ChangeState<LoadingState>();
    }


    public void Exit()
    {
        Debug.Log("Выходим из EntryPointState...");
    }
}