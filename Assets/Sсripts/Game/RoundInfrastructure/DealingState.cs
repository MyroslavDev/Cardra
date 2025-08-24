using UnityEngine;

public class DealingState : IRoundState
{
    private readonly RoundStateMachine _machine;

    public DealingState(RoundStateMachine machine)
    {
        _machine = machine;
    }

    public void Enter()
    {
        Debug.Log("Dealing: раздаём карты игрокам");
        _machine.ChangeState<PreflopState>();
    }

    public void Exit()
    {
        Debug.Log("Выходим из DealingState");
    }

    public void OnPlayerAction()
    {
        Debug.Log("Игрок сделал ход на Flop");
        _machine.ChangeState<PreflopState>();
    }
}