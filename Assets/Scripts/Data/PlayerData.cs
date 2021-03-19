using UnityEngine;

namespace MVCExample
{
    [CreateAssetMenu(fileName = "UnitSettings", menuName = "Data/Unit/UnitSettings")]
    public sealed class PlayerData : ScriptableObject, IUnit
    {
        public Sprite Sprite;
        [SerializeField, Range(0, 100)] private float _speed;
        [SerializeField] private Vector2Int _position;
        public float Speed => _speed;
        public Vector2 Position => _position;
    }
}
