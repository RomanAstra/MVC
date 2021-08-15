using System.Collections.Generic;
using UnityEngine;

namespace MVCExample
{
    internal sealed class EndGameController  : IInitialization, ICleanup
    {
        private readonly IEnumerable<IEnemy> _getEnemies;
        private readonly int _playerID;

        public EndGameController(IEnumerable<IEnemy> getEnemies, int playerID)
        {
            _getEnemies = getEnemies;
            _playerID = playerID;
        }

        public void Initialization()
        {
            foreach (var enemy in _getEnemies)
            {
                enemy.OnTriggerEnterChange += EnemyOnOnTriggerEnterChange;
            }
        }

        private void EnemyOnOnTriggerEnterChange(int value)
        {
            if (value == _playerID)
            {
                Debug.Log(22);
            }
        }

        public void Cleanup()
        {
            foreach (var enemy in _getEnemies)
            {
                enemy.OnTriggerEnterChange -= EnemyOnOnTriggerEnterChange;
            }
        }
    }
}
