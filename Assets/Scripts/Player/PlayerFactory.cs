using UnityEngine;

namespace MVCExample
{
    public sealed class PlayerFactory : IPlayerFactory
    {
        private readonly PlayerData _playerData;

        public PlayerFactory(PlayerData playerData)
        {
            _playerData = playerData;
        }

        public Transform CreatePlayer()
        {
           return new GameObject(_playerData.Name).
               AddSprite(_playerData.Sprite).AddCircleCollider2D().
               AddCircleCollider2D().AddTrailRenderer().transform;
        }
    }
}
