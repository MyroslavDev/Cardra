using UnityEngine;

public class TurnState : IRoundState
{
    private readonly RoundStateMachine _machine;

    public TurnState(RoundStateMachine machine)
    {
        _machine = machine;
    }

    public void Enter()
    {
        Debug.Log("Turn: открываем одну карту");
        
    }

    public void Exit()
    {
        Debug.Log("Выходим из TurnState");
    }
    public void OnPlayerAction()
    {
        Debug.Log("Игрок сделал ход на  Терне");
        _machine.ChangeState<RiverState>();
    }
}