using UnityEngine;


public class LoadingState : IGameState
{
    private readonly GameStateMachine _stateMachine;
    private readonly SceneLoader _sceneLoader;

    public LoadingState(GameStateMachine stateMachine, MonoBehaviour coroutineRunner)
    {
        _stateMachine = stateMachine;
        _sceneLoader = new SceneLoader(coroutineRunner);
    }

    public void Enter()
    {
        Debug.Log("Загрузка сцены началась...");
        _sceneLoader.Load("Game", OnLoaded);
    }

    public void Exit()
    {
        Debug.Log("Выходим из LoadingState...");
    }

    private void OnLoaded()
    {
        Debug.Log("Сцена загружена → переключаемся в GameLoopState");
        _stateMachine.ChangeState<GameLoopState>();
    }
}