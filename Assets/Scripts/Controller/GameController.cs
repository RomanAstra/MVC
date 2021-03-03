using UnityEngine;

namespace MVCExample
{
    public sealed class GameController : MonoBehaviour
    {
        [SerializeField] private Data _data;
        private Controllers _controllers;
        
        private void Start()
        {
            _controllers = new Controllers();
           new GameInitialization(_controllers, _data);
            _controllers.Initialization();
        }

        private void Update()
        {
            var deltaTime = Time.deltaTime;
            _controllers.Execute(deltaTime);
        }

        private void LateUpdate()
        {
            var deltaTime = Time.deltaTime;
            _controllers.LateExecute(deltaTime);
        }



        private void OnDestroy()
        {
            _controllers.Cleanup();
        }
    }
}
