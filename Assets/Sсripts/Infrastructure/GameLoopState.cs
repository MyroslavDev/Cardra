using UnityEngine;

public class GameLoopState : IGameState
{
    private GameStateMachine _stateMachine;
    private RoundStateMachine _roundStateMachine;

    public GameLoopState(GameStateMachine stateMachine)
    {
        _stateMachine = stateMachine;
    }

    public void Enter()
    {
        Debug.Log("Игра началась!");

        var roundMachine = new RoundStateMachine();
        roundMachine.StartRound();

        var actionButton = GameObject.FindObjectOfType<PlayerActionButton>();
        actionButton.Init(roundMachine);
    }


    public void Exit()
    {
        Debug.Log("Игра закончена, выходим из GameLoopState...");
    }
}