using UnityEngine;

namespace MVCExample
{
    public interface IPlayerFactory
    {
        Transform CreatePlayer();
    }
}
