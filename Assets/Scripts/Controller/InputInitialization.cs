namespace MVCExample
{
    internal sealed class InputInitialization : IInitialization
    {
        private IUserInputProxy _pcInputHorizontal;
        private IUserInputProxy _pcInputVertical;

        public InputInitialization()
        {
            _pcInputHorizontal = new PCInputHorizontal();
            _pcInputVertical = new PCInputVertical();
        }
        
        public void Initialization()
        {
        }

        public (IUserInputProxy inputHorizontal, IUserInputProxy inputVertical) GetInput()
        {
            (IUserInputProxy inputHorizontal, IUserInputProxy inputVertical) result = (_pcInputHorizontal, _pcInputVertical);
            return result;
        }
    }
}
