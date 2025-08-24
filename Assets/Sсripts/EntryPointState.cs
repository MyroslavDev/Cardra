
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
        Debug.Log("Entry Point: загрузка меню или стартовых экранов...");
        // Тут можно показать меню, загрузочный экран и т.д.
        // Для примера: сразу идем в игру
        _stateMachine.ChangeState<GameLoopState>();
    }

    public void Exit()
    {
        Debug.Log("Выходим из EntryPointState...");
    }
}