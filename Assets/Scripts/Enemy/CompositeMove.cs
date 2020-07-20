using System.Collections.Generic;
using UnityEngine;

namespace MVCExample
{
    public sealed class CompositeMove : IMove
    {
        private List<IMove> _moves = new List<IMove>();

        public void AddUnit(IMove unit)
        {
            _moves.Add(unit);
        }

        public void RemoveUnit(IMove unit)
        {
            _moves.Remove(unit);
        }

        
        public void Move(Vector3 point)
        {
            for (var i = 0; i < _moves.Count; i++)
            {
                _moves[i].Move(point);
            }
        }
    }
}
