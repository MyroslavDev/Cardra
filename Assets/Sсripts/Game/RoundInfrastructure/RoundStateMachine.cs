using System;
using System.Collections.Generic;
using UnityEngine;

public class RoundStateMachine
{
    private readonly Dictionary<Type, IRoundState> _states;
    private IRoundState _currentState;

    public IRoundState CurrentState => _currentState; // 👈 теперь доступно снаружи

    public RoundStateMachine()
    {
        _states = new Dictionary<Type, IRoundState>
        {
            { typeof(DealingState), new DealingState(this) },
            { typeof(PreflopState), new PreflopState(this) },
            { typeof(FlopState), new FlopState(this) },
            { typeof(TurnState), new TurnState(this) },
            { typeof(RiverState), new RiverState(this) },
            { typeof(ResultState), new ResultState(this) },
            { typeof(EndRoundState), new EndRoundState(this) },
        };
    }

    public void ChangeState<T>() where T : IRoundState
    {
        _currentState?.Exit();
        _currentState = _states[typeof(T)];
        _currentState.Enter();
    }

    public void StartRound()
    {
        ChangeState<DealingState>();
    }
}