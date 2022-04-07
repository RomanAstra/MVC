using UnityEngine;

namespace MVCExample
{
    public sealed class EnemyMoveController : IExecute
    {
        private readonly IMove _move;
        private readonly Transform _target;

        public EnemyMoveController(IMove move, Transform target)
        {
            _move = move;
            _target = target;
        }

        public void Execute(float deltaTime)
        {
            _move.Move(_target.localPosition);
        }
    }
}
