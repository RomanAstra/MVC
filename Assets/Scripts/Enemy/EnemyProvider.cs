using UnityEngine;

namespace MVCExample
{
    public sealed class EnemyProvider : MonoBehaviour, IEnemy
    {
        [SerializeField] private float _speed;
        [SerializeField] private float _stopDistance;
        private Rigidbody2D _rigidbody2D;
        private Transform _transform;

        private void Start()
        {
            _rigidbody2D = GetComponent<Rigidbody2D>();
            _transform = transform;
        }

        public void Move(Vector3 point)
        {
            if ((_transform.localPosition - point).sqrMagnitude >= _stopDistance * _stopDistance)
            {
                var dir = (point - _transform.localPosition).normalized;
                _rigidbody2D.velocity = dir * _speed;
            }
            else
            {
                _rigidbody2D.velocity = Vector2.zero;
            }
        }
    }
}
