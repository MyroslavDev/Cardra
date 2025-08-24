using UnityEngine;

public class RiverState : IRoundState
{
    private readonly RoundStateMachine _machine;

    public RiverState(RoundStateMachine machine)
    {
        _machine = machine;
    }

    public void Enter()
    {
        Debug.Log("River: открываем последнюю карту");
        
    }

    public void Exit()
    {
        Debug.Log("Выходим из RiverState");
    }
    public void OnPlayerAction()
    {
        Debug.Log("Переходти в подсчет");
        _machine.ChangeState<ResultState>();
    }
}