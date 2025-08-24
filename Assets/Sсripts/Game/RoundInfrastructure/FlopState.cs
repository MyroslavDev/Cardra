using UnityEngine;

public class FlopState : IRoundState
{
    private readonly RoundStateMachine _machine;

    public FlopState(RoundStateMachine machine)
    {
        _machine = machine;
    }

    public void Enter()
    {
        Debug.Log("Flop: открыты три карты, жмём кнопку Сделать ход");
    }

    public void Exit()
    {
        Debug.Log("Выходим из FlopState");
    }

    public void OnPlayerAction()
    {
        Debug.Log("Игрок сделал ход на Flop");
        _machine.ChangeState<TurnState>();
    }
}