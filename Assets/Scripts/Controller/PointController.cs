using Model;
using UnityEngine;
using View;

namespace MVCExample
{
    internal sealed class PointController : IExecute
    {
        private readonly IPointData _pointData;
        private readonly IPointView _pointView;

        public PointController(IPointData pointData, IPointView pointView)
        {
            _pointData = pointData;
            _pointView = pointView;
        }
        
        public void Execute(float deltaTime)
        {
            if (Input.GetMouseButtonUp(2))
            {
                _pointView.UpdatePoint(_pointData);
            }
        }
    }
}
