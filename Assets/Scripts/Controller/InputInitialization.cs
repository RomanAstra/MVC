using UnityEngine.UI;

namespace MVCExample
{
    internal sealed class InputInitialization : IInitialization
    {
        private IUserInputProxy _pcInputHorizontal;
        private IUserInputProxy _pcInputVertical;
        private Button _button;
        private MobileInput _mobileInput;

        public InputInitialization(IMobileInputFactory mobileInputFactory)
        {
            _pcInputHorizontal = new PCInputHorizontal();
            _pcInputVertical = new PCInputVertical();
            _button = mobileInputFactory.Create();
            _mobileInput = new MobileInput();
            _button.onClick.AddListener(_mobileInput.GetAxis);
        }
        
        public void Initialization()
        {
        }

        public (IUserInputProxy inputHorizontal, IUserInputProxy inputVertical) GetInput()
        {
            (IUserInputProxy inputHorizontal, IUserInputProxy inputVertical) result = (_pcInputHorizontal, _pcInputVertical);
            return result;
        }

        ~InputInitialization()
        {
            _button.onClick.RemoveListener(_mobileInput.GetAxis);
        }
    }
}
