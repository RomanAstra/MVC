using UnityEngine;

namespace MVCExample
{
    internal sealed class CameraInitialization : IInitialization
    {
        private readonly Transform _camera;
        private readonly Vector2 _positionPlayer;

        public CameraInitialization(Transform camera, Vector2 positionPlayer)
        {
            _camera = camera;
            _positionPlayer = positionPlayer;
        }
        
        public void Initialization()
        {
            _camera.position = new Vector3(_positionPlayer.x, _positionPlayer.y, _camera.position.z);
        }
    }
}
