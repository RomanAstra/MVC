using System.IO;
using UnityEngine;


namespace MVCExample
{
    [CreateAssetMenu(fileName = "Data", menuName = "Data/Data")]
    public sealed class Data : ScriptableObject
    {
        [SerializeField] private string _playerDataPath;
        [SerializeField] private string _enemyDataPath;
        private PlayerData _player;
        private EnemyData _enemy;
    

        public PlayerData Player
        {
            get
            {
                if (_player == null)
                {
                    _player = Load<PlayerData>("Data/" + _playerDataPath);
                }

                return _player;
            }
        }
    

        public EnemyData Enemy
        {
            get
            {
                if (_enemy == null)
                {
                    _enemy = Load<EnemyData>("Data/" + _enemyDataPath);
                }

                return _enemy;
            }
        }
        
        
        private T Load<T>(string resourcesPath) where T : Object =>
            Resources.Load<T>(Path.ChangeExtension(resourcesPath, null));
    }
}
