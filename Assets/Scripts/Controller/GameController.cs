using UnityEngine;
using UnityEngine.UI;

namespace MVCExample
{
    public sealed class GameController : MonoBehaviour
    {
        [SerializeField] private Data _data;
        [SerializeField] private Transform _canvas;
        [SerializeField] private Button _button;
        private Controllers _controllers;
        
        private void Start()
        {
            Camera camera = Camera.main;
            var inputInitialization = new InputInitialization(new MobileInputFactory(_canvas, _button));
            var playerFactory = new PlayerFactory(_data.Player);
            var playerInitialization = new PlayerInitialization(playerFactory);
            var enemyFactory = new EnemyFactory(_data.Enemy);
            var enemyInitialization = new EnemyInitialization(enemyFactory);
            _controllers = new Controllers();
            _controllers.Add(inputInitialization);
            _controllers.Add(playerInitialization);
            _controllers.Add(enemyInitialization);
            _controllers.Add(new InputController(inputInitialization.GetInput()));
            _controllers.Add(new MoveController(inputInitialization.GetInput(), playerInitialization.GetPlayer(), _data.Player));
            _controllers.Add(new EnemyMoveController(enemyInitialization.GetEnemy(), playerInitialization.GetPlayer()));
            _controllers.Add(new CameraController(playerInitialization.GetPlayer(), camera.transform));
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
