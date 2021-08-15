using Model;
using UnityEngine;
using View;

namespace MVCExample
{
    internal sealed class GameInitialization
    {
        public GameInitialization(Controllers controllers, Data data)
        {
            Camera camera = Camera.main;
            var inputInitialization = new InputInitialization();
            var playerFactory = new PlayerFactory(data.Player);
            var playerInitialization = new PlayerInitialization(playerFactory, data.Player.Position);
            var enemyFactory = new EnemyFactory(data.Enemy);
            var enemyInitialization = new EnemyInitialization(enemyFactory);
           controllers.Add(inputInitialization);
           controllers.Add(playerInitialization);
           controllers.Add(enemyInitialization);
           controllers.Add(new InputController(inputInitialization.GetInput()));
           controllers.Add(new MoveController(inputInitialization.GetInput(), playerInitialization.GetPlayer(), data.Player));
           controllers.Add(new EnemyMoveController(enemyInitialization.GetMoveEnemies(), playerInitialization.GetPlayer()));
           controllers.Add(new CameraController(playerInitialization.GetPlayer(), camera.transform));
           controllers.Add(new EndGameController(enemyInitialization.GetEnemies(), playerInitialization.GetPlayer().gameObject.GetInstanceID()));
        }
    }
}
