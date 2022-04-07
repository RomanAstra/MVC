using UnityEngine;
using UnityEngine.UI;

namespace MVCExample
{
    internal sealed class MobileInputFactory : IMobileInputFactory
    {
        private readonly Transform _root;
        private readonly Button _gameObject;

        public MobileInputFactory(Transform root, Button gameObject)
        {
            _root = root;
            _gameObject = gameObject;
        }
        
        public Button Create()
        {
            return Object.Instantiate(_gameObject, _root);
        }
    }
}
