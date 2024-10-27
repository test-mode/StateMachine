namespace TestMode.StateMachine
{
    public abstract class State<T>
    {
        public abstract void Enter(T owner);
        public abstract void Update(T owner);
        public abstract void Exit(T owner);
    }
}
