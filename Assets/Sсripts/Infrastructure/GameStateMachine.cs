using System;
using System.Collections.Generic;
using UnityEngine;


public class GameStateMachine
{
    private readonly Dictionary<Type, IGameState> _states;
    private IGameState _currentState;

    public GameStateMachine(MonoBehaviour coroutineRunner)
    {
        _states = new Dictionary<Type, IGameState>
        {
            { typeof(EntryPointState), new EntryPointState(this) },
            { typeof(LoadingState), new LoadingState(this, coroutineRunner) },
            { typeof(GameLoopState), new GameLoopState(this) }
        };
    }

    public void ChangeState<T>() where T : IGameState
    {
        _currentState?.Exit();
        _currentState = _states[typeof(T)];
        _currentState.Enter();
    }
}

