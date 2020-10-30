namespace MVCExample
{
    public interface ILateExecute : IController
    {
        void LateExecute(float deltaTime);
    }
}
