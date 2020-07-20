namespace MVCExample
{
    public sealed class Controllers : IInitialization
    {
        private readonly IExecute[] _executeControllers;

        public int Length => _executeControllers.Length;
        
        public IExecute this[int index] => _executeControllers[index];

        public Controllers(Data data)
        {
            var pcInputHorizontal = new PCInputHorizontal();
            var pcInputVertical = new PCInputVertical();
            
            IPlayerFactory playerFactory = new PlayerFactory(data.Player);
            var player = playerFactory.CreatePlayer();
           
            IEnemyFactory enemyFactory = new EnemyFactory();
            CompositeMove enemy = new CompositeMove();
            enemy.AddUnit(enemyFactory.CreateEnemy(data.Enemy, EnemyType.Small));
            
            _executeControllers = new IExecute[3];
            _executeControllers[0] = new InputController(pcInputHorizontal, pcInputVertical);
            _executeControllers[1] = new MoveController(pcInputHorizontal, pcInputVertical, player, data.Player);
            _executeControllers[2] = new EnemyMoveController(enemy, player);
        }

        public void Initialization()
        {
        }
    }
}
