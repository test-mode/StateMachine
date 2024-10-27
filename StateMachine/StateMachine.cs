namespace TestMode.StateMachine
{
    public class StateMachine<T>
    {
        private readonly T _owner;
        private State<T> _currentState;

        public State<T> CurrentState
        {
            get { return _currentState; }
            set { ChangeState(value); }
        }

        public StateMachine(T owner)
        {
            _owner = owner;
            _currentState = null;
        }

        public void ChangeState(State<T> newState)
        {
            _currentState?.Exit(_owner);

            _currentState = newState;
            _currentState.Enter(_owner);
        }

        public void Update()
        {
            _currentState?.Update(_owner);
        }
    }
}
