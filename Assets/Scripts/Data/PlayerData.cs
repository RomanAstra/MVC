using UnityEngine;

namespace MVCExample
{
    [CreateAssetMenu(fileName = "UnitSettings", menuName = "Data/Unit/UnitSettings")]
    public sealed class PlayerData : ScriptableObject, IUnit
    {
        public Sprite Sprite;
        [SerializeField, Range(0, 100)] private float _speed;
        public float Speed => _speed;
    }
}
