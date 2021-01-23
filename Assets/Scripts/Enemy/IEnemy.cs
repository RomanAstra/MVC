using System;

namespace MVCExample
{
    public interface IEnemy : IMove
    {
        event Action<int> OnTriggerEnterChange;
    }
}
