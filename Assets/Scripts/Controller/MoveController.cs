using UnityEngine;

namespace MVCExample
{
    public sealed class MoveController : IExecute, ICleanup
    {
        private readonly Transform _unit;
        private readonly IUnit _unitData;
        private float _horizontal;
        private float _vertical;
        private Vector3 _move;
        private IUserInputProxy _horizontalInputProxy;

        public MoveController(IUserInputProxy horizontal, IUserInputProxy vertical, Transform unit, IUnit unitData)
        {
            _unit = unit;
            _unitData = unitData;
            _horizontalInputProxy = horizontal;
            _horizontalInputProxy.AxisOnChange += HorizontalOnAxisOnChange;
            vertical.AxisOnChange += f => _vertical = f;
        }

        private void HorizontalOnAxisOnChange(float value)
        {
            _horizontal = value;
        }

        public void Execute(float deltaTime)
        {
            var speed = deltaTime * _unitData.Speed;
            _move.Set(_horizontal * speed, _vertical * speed, 0.0f);
            _unit.localPosition += _move;
        }

        public void Cleanup()
        {
            _horizontalInputProxy.AxisOnChange -= HorizontalOnAxisOnChange;
        }
    }
}
