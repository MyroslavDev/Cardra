
using UnityEngine;

public class GameLoopState : IGameState
{
    private GameStateMachine _stateMachine;

    public GameLoopState(GameStateMachine stateMachine)
    {
        _stateMachine = stateMachine;
    }

    public void Enter()
    {
        Debug.Log("Игра началась!");
        // Тут запускается игровой процесс
    }

    public void Exit()
    {
        Debug.Log("Игра закончена, выходим из GameLoopState...");
    }
}