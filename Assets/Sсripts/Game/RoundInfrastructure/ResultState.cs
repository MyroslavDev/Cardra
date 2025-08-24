using UnityEngine;

public class ResultState : IRoundState
{
    private readonly RoundStateMachine _machine;

    public ResultState(RoundStateMachine machine)
    {
        _machine = machine;
    }

    public void Enter()
    {
        Debug.Log("Result: подсчёт урона/определение победителя");
    
    }

    public void Exit()
    {
        Debug.Log("Выходим из ResultState");
    } public void OnPlayerAction()
    {
        Debug.Log("переходим в конец раунда");
        _machine.ChangeState<EndRoundState>();
    }
}