using UnityEngine;
using UnityEngine.UI;

public class PlayerActionButton : MonoBehaviour
{
    [SerializeField] private Button _button;
    private RoundStateMachine _roundStateMachine;

    public void Init(RoundStateMachine machine)
    {
        _roundStateMachine = machine;
        _button.onClick.AddListener(OnClick);
    }

    private void OnClick()
    {
        Debug.Log("Нажали кнопку Сделать ход");

        // говорим текущему стейту: игрок сделал ход
        if (_roundStateMachine.CurrentState is PreflopState preflop)
            preflop.OnPlayerAction();
        else if (_roundStateMachine.CurrentState is FlopState flop)
            flop.OnPlayerAction();
        else if (_roundStateMachine.CurrentState is TurnState turn)
            turn.OnPlayerAction();
        else if (_roundStateMachine.CurrentState is RiverState river)
            river.OnPlayerAction();
        else if (_roundStateMachine.CurrentState is ResultState result)
            result.OnPlayerAction();
        else if (_roundStateMachine.CurrentState is EndRoundState end)
            end.OnPlayerAction();
    }
}   