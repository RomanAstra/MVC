using UnityEngine;

namespace MVCExample
{
    public sealed class GameController : MonoBehaviour
    {
        [SerializeField] private Data _data;
        private Controllers _controllers;
        
        private void Start()
        {
            _controllers = new Controllers(_data);
            _controllers.Initialization();
        }

        private void Update()
        {
            var deltaTime = Time.deltaTime;
            for (var i = 0; i < _controllers.Length; i++)
            {
                _controllers[i].Execute(deltaTime);
            }
        }
    }
}
