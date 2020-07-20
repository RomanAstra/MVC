using UnityEngine;

namespace MVCExample
{
    public sealed class MoveController : IExecute
    {
        private readonly Transform _unit;
        private readonly IUnit _unitData;
        private float _horizontal;
        private float _vertical;
        private Vector3 _move;

        public MoveController(IUserInputProxy horizontal, IUserInputProxy vertical, Transform unit, IUnit unitData)
        {
            _unit = unit;
            _unitData = unitData;
            horizontal.AxisOnChange += f => _horizontal = f;
            vertical.AxisOnChange += f => _vertical = f;
        }
        
        public void Execute(float deltaTime)
        {
            var speed = deltaTime * _unitData.Speed;
            _move.Set(_horizontal * speed, _vertical * speed, 0.0f);
            _unit.transform.localPosition += _move;
        }
    }
}
