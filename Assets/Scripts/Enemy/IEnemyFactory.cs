namespace MVCExample
{
    public interface IEnemyFactory
    {
        IEnemy CreateEnemy(EnemyData data, EnemyType type);
    }
}
