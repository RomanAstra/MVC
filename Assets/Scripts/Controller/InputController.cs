namespace MVCExample
{
    public sealed class InputController : IExecute
    {
        private readonly IUserInputProxy _horizontal;
        private readonly IUserInputProxy _vertical;
        
        public InputController(IUserInputProxy horizontal, IUserInputProxy vertical)
        {
            _horizontal = horizontal;
            _vertical = vertical;
        }
        
        public void Execute(float deltaTime)
        {
            _horizontal.GetAxis();
            _vertical.GetAxis();
        }
    }
}
