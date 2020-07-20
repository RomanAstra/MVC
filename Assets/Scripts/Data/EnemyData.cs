using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace MVCExample
{
    [CreateAssetMenu(fileName = "EnemySettings", menuName = "Data/Unit/EnemySettings")]
    public sealed class EnemyData : ScriptableObject
    {
        [Serializable] 
        private struct EnemyInfo
        {
            public EnemyType Type;
            public EnemyProvider EnemyPrefab;
        }

        [SerializeField] private List<EnemyInfo> _enemyInfos;

        public EnemyProvider GetEnemy(EnemyType type)
        {
            var enemyInfo = _enemyInfos.First(info => info.Type == type);
            return enemyInfo.EnemyPrefab;
        }
    }
}