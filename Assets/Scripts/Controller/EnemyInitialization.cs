using System.Collections.Generic;

namespace MVCExample
{
    internal sealed class EnemyInitialization : IInitialization
    {
        private readonly IEnemyFactory _enemyFactory;
        private CompositeMove _enemy;
        private List<IEnemy> _enemies;

        public EnemyInitialization(IEnemyFactory enemyFactory)
        {
            _enemyFactory = enemyFactory;
            _enemy = new CompositeMove();
            var enemy = _enemyFactory.CreateEnemy(EnemyType.Small);
            _enemy.AddUnit(enemy);
            _enemies = new List<IEnemy>
            {
                enemy
            };
        }
        
        public void Initialization()
        {
        }

        public IMove GetMoveEnemies()
        {
            return _enemy;
        }

        public IEnumerable<IEnemy> GetEnemies()
        {
            foreach (var enemy in _enemies)
            {
                yield return enemy;
            }
        }
    }
}
