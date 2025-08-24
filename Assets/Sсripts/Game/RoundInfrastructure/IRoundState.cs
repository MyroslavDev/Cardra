
    public interface IRoundState
    {
        void Enter();
        void Exit();
        void OnPlayerAction(); // 👈 универсальный метод
    }

