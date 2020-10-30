namespace MVCExample
{
    internal sealed class EnemyInitialization : IInitialization
    {
        private readonly IEnemyFactory _enemyFactory;
        private CompositeMove _enemy;

        public EnemyInitialization(IEnemyFactory enemyFactory)
        {
            _enemyFactory = enemyFactory;
            _enemy = new CompositeMove();
            _enemy.AddUnit(_enemyFactory.CreateEnemy(EnemyType.Small));
        }
        
        public void Initialization()
        {
        }

        public IMove GetEnemy()
        {
            return _enemy;
        }
    }
}
