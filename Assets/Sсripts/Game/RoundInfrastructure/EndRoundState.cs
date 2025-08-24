using UnityEngine;

public class EndRoundState : IRoundState
{
    private readonly RoundStateMachine _machine;

    public EndRoundState(RoundStateMachine machine)
    {
        _machine = machine;
    }

    public void Enter()
    {
        Debug.Log("Раунд завершён. Решаем: новая раздача или конец игры");
      
    }

    public void Exit()
    {
        Debug.Log("Выходим из EndRoundState");
    }
    public void OnPlayerAction()
    {
        Debug.Log("Раздаем карты");
        _machine.ChangeState<DealingState>();
    }
}