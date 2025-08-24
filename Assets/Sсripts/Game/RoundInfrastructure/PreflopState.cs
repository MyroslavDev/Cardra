using UnityEngine;

public class PreflopState : IRoundState
{
    private readonly RoundStateMachine _machine;

    public PreflopState(RoundStateMachine machine)
    {
        _machine = machine;
    }

    public void Enter()
    {
        Debug.Log("Preflop: игрок думает... нажми кнопку Сделать ход");
    }

    public void Exit()
    {
        Debug.Log("Выходим из PreflopState");
    }

    // этот метод вызовет кнопка
    public void OnPlayerAction()
    {
        Debug.Log("Игрок сделал ход на Preflop");
        _machine.ChangeState<FlopState>();
    }
}